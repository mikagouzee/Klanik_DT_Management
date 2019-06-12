#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#addin "Cake.Putty"
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

var configuration = Argument("configuration", "Release");

var framework = Argument("framework", "netcoreapp2.0");

var runtime = Argument("runtime", "win10-arm");

var destinationIp = Argument("DestinationIp", ""); //TODO : CHANGE DEFAULT DESTINATION IP

var destinationDirectory = Argument("destinationDirectory", @"c$\ConsoleApps\Test"); //TODO : CHANGE DEFAULT DESTINATION DIRECTORY

var username = Argument("username", "ubuntu"); //not needed for windows, so default is ubuntu
var executableName = Argument("executableName", "IdentityServer")

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
//var buildDir = Directory("./src/Example/bin") + Directory(configuration);

var binaryDir = Directory("IdentityServer/bin");
var objectDir = Directory("IdentityServer/obj");
var publishDir = Directory("IdentityServer/publish");

//Define ProjectFiles
var projectFile = "IdentityServer/IdentityServer.csproj";
//var projectFile_Identity = "./IdentityServer/IdentityServer.csproj";
//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>{
    //CleanDirectory(buildDir);

    CleanDirectory(binaryDir);
    CleanDirectory(objectDir);
    CleanDirectory(publishDir);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() => {
        DotNetCoreRestore(projectFile);
})

Task("Build")
    .IsDependentOn("Restore")
    .Does(() => {
        var settings = new DotNetCoreBuildSettings{
            Framework = framework,
            configuration = configuration,
            OutputDirectory = "IdentityServer/bin/"
        };

        DotNetCoreBuild(projectFile, settings);
})

Task("Publish")
    .IsDependentOn("Build")
    .Does(()=> {
        var settings = new DotNetCorePublishSettings{
            Framework = framework,
            Configuration = configuration,
            OutputDirectory = "IdentityServer/publish/",
            Runtime = runtime
        };

        DotNetCorePublish(projectFile, settings);
})

Task("Deploy")
    .IsDependentOn("Publish")
    .Does(()=>{
        var files = GetFiles("IdentityServer/publish/*");

        if(runtime.StartsWith("win")){
             var destination = @"\\"+ destinationIp + @"\" + destinationDirectory;
            CopyFiles(files, destination, true);
        }
        else{
           var destination = destinationIp + ":" + destinationDirectory;

           var fileArray = files.Select(m => m.ToString()).ToArray();

           Pscp(fileArray, destination, new PscpSettings{
               SshVersion = SshVersion.V2,
               User = username
           });

           var plinkCommand = "chmod u+x,o+x "+ destinationDirectory + "/" + executableName;
           Plink(username + "@" + destination, plinkCommand);

        }       
})


//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
