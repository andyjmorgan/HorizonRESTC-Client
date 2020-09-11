using System;
using System.Threading.Tasks;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Model;

namespace VMware.Horizon.RESTAPI.Client
{
    public class HorizonRESTClient
    {
        private Uri BaseURI { get; set; }
        private AuthTokens Tokens { get; set; }
        public Configuration ClientConfiguration { get; set; }
        public HorizonRESTClient(string BaseURL)
        {
            BaseURI = new Uri(BaseURL);
            ClientConfiguration = new Configuration();
            ClientConfiguration.BasePath = BaseURI.AbsoluteUri;
            Authentication = new AuthApi(ClientConfiguration);
            Configuration = new ConfigApi(ClientConfiguration);
            Entitlements = new EntitlementsApi(ClientConfiguration);
            External = new ExternalApi(ClientConfiguration);
            Inventory = new InventoryApi(ClientConfiguration);
            Monitoring = new MonitorApi(ClientConfiguration);
        }

        public AuthApi Authentication { get; set; }
        public ConfigApi Configuration { get; set; }
        public EntitlementsApi Entitlements { get; set; }
        public ExternalApi External { get; set; }
        public InventoryApi Inventory { get; set; }
        public MonitorApi Monitoring { get; set; }



        private bool AddTokens(AuthTokens Token)
        {
            if (string.IsNullOrEmpty(Token?.AccessToken) || string.IsNullOrEmpty(Token?.RefreshToken))
            {
                throw new Exception("The tokens provided are empty or null");
            }
            else
            {
                Tokens = Token;
                ClientConfiguration.AddApiKey("Authorization", string.Format("Bearer {0}", Token.AccessToken));
                return true;
            }
        }

        private bool RefreshToken(AccessToken Token)
        {
            if (string.IsNullOrEmpty(Token?._AccessToken))
            {
                throw new Exception("Access Token received was null or empty");
            }

            ClientConfiguration.AddApiKey("Authorization", string.Format("Bearer {0}", Token._AccessToken));
            return true;
        }

        private bool LogOut(ApiResponse<object> LogoutResponse)
        {
            if (LogoutResponse.StatusCode == 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Logon(string username, string password, string domain)
        {
            AuthTokens tokens = Authentication.LoginUser(new Model.AuthLogin(domain,
                password,
                username
            ));
            return AddTokens(tokens);
           
        }
        public async Task<bool> LogonAsync(string username, string password, string domain)
        {
            AuthTokens tokens = await Authentication.LoginUserAsync(new Model.AuthLogin(domain,
                password,
                username
            ));
            return AddTokens(tokens);
        }



        public bool RefreshToken()
        {
            AccessToken Token = Authentication.RefreshAccessToken(new RefreshToken(Tokens.RefreshToken));
            return RefreshToken(Token);          
        }
        public async Task<bool> RefreshTokenAsync()
        {
            AccessToken Token = await Authentication.RefreshAccessTokenAsync(new RefreshToken(Tokens.RefreshToken));
            return RefreshToken(Token);

        }

        public bool LogOut()
        {
            return LogOut(Authentication.LogoutUserWithHttpInfo(new RefreshToken(Tokens.RefreshToken)));
        }

        public async Task<bool> LogOutAsync()
        {
            return LogOut(await Authentication.LogoutUserAsyncWithHttpInfo(new RefreshToken(Tokens.RefreshToken)));
        }

        public Uri GetConnectionURI()
        {
            return BaseURI;
        } 
    }
}
