using IdentityServer4;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityServer {
    public class Config {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };
        }


        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "Klanik API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                
                // resource owner password grant client
                //todo : adapt name of scopes and apiresources
                new Client
                {
                    ClientId = "ro.VueJs",
                    ClientName = "Klanik front end",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    ClientSecrets =
                    {
                        new Secret("klanik_front_app".Sha256())
                    },
                    RequireConsent = false,
                    RedirectUris = { "http://localhost:8080/login" },

                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.Address,
                        "api1"
                    },
                    AlwaysSendClientClaims = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowedCorsOrigins= new List<string>
                    {
                        "http://localhost:8080"
                    }
                },

            };
        }
    }
}


public class PublicFacingUrlMiddleware {
    private readonly RequestDelegate _next;
    private readonly string _publicFacingUri;

    public PublicFacingUrlMiddleware(RequestDelegate next, string publicFacingUri)
    {
        _publicFacingUri = publicFacingUri;
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var request = context.Request;

        context.SetIdentityServerOrigin(_publicFacingUri);
        context.SetIdentityServerBasePath(request.PathBase.Value.TrimEnd('/'));

        await _next(context);
    }
}
