using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVault_ManagedIdentity_Example
{
    public class KeyVaultHandler
    {
        private SecretClient secretClient { get; set; }
        public KeyVaultHandler(string keyVaultUrl)
        {
            secretClient = CreateSecretClient(keyVaultUrl);
        }

        public SecretClient CreateSecretClient(string url)
        {   
            return new SecretClient(new Uri(url), new DefaultAzureCredential());
        } 

        public SecretClient GetSecretClient()
        {
            return this.secretClient;
        }
    }
}
