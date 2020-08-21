using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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



        public void Logon(string username, string password, string domain)
        {
            var tokens = Authentication.LoginUser(new Model.AuthLogin(domain,
                password,
                username
            ));
            if (null == tokens || string.IsNullOrEmpty(tokens.AccessToken) || string.IsNullOrEmpty(tokens.RefreshToken))
            {
                throw new Exception("The tokens provided are empty or null");
            }
            else
            {
                Tokens = tokens;
                ClientConfiguration.AddApiKey("Authorization", string.Format("Bearer {0}", tokens.AccessToken));
            }
        }

        public void TryRefreshSession()
        {
            AccessToken Token = Authentication.RefreshAccessToken(new RefreshToken(Tokens.RefreshToken));
            if (Token == null)
            {
                throw new Exception("Access Token received was null or empty");
            }

            if (string.IsNullOrEmpty(Token._AccessToken))
            {
                throw new Exception("Access Token received was null or empty");
            }

            ClientConfiguration.AddApiKey("Authorization", string.Format("Bearer {0}", Token._AccessToken));
        }

        public void LogOut()
        {
            Authentication.LogoutUser(new RefreshToken(Tokens.RefreshToken));
        }
    }
}
