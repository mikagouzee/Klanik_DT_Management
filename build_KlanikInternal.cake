#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#addin "Cake.Putty"
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Clean");

var configuration = Argument("configuration", "Release");

var framework = Argument("framework", "netcoreapp2.0");

var runtime = Argument("runtime", "win10-arm");

var destinationIp = Argument("DestinationIp", ""); //TODO : CHANGE DEFAULT DESTINATION IP

var destinationDirectory = Argument("destinationDirectory", @"c$\ConsoleApps\Test"); //TODO : CHANGE DEFAULT DESTINATION DIRECTORY

var username = Argument("username", "ubuntu"); //not needed for windows, so default is ubuntu
var executableName = Argument("executableName", "Klanik_Internal")

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
//var buildDir = Directory("./src/Example/bin") + Directory(configuration);

var binaryDir = Directory("Klanik_Internal/bin");
var objectDir = Directory("Klanik_Internal/obj");
var publishDir = Directory("Klanik_Internal/publish");

//Define ProjectFiles
var projectFile = "Klanik_Internal/Klanik_Internal.csproj";
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
            OutputDirectory = "Klanik_Internal/bin/"
        };

        DotNetCoreBuild(projectFile, settings);
})

Task("Publish")
    .IsDependentOn("Build")
    .Does(()=> {
        var settings = new DotNetCorePublishSettings{
            Framework = framework,
            Configuration = configuration,
            OutputDirectory = "Klanik_Internal/publish/",
            Runtime = runtime
        };

        DotNetCorePublish(projectFile, settings);
})

Task("Deploy")
    .IsDependentOn("Publish")
    .Does(()=>{
        var files = GetFiles("Klanik_Internal/publish/*");

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


//Previous version
#region original version commented out
// Task("Restore-NuGet-Packages")
//     .IsDependentOn("Clean")
//     .Does(() =>
// {
//     NuGetRestore("./src/Example.sln");
// });
// Task("Build")
//     .IsDependentOn("Restore-NuGet-Packages")
//     .Does(() =>
// {
//     if(IsRunningOnWindows())
//     {
//       // Use MSBuild
//       MSBuild("./src/Example.sln", settings =>
//         settings.SetConfiguration(configuration));
//     }
//     else
//     {
//       // Use XBuild
//       XBuild("./src/Example.sln", settings =>
//         settings.SetConfiguration(configuration));
//     }
// });
#endregion


//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

// Task("Default")
//     .IsDependentOn("Run-Unit-Tests");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
