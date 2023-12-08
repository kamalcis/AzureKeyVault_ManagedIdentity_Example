// See https://aka.ms/new-console-template for more information
using AzureKeyVault_ManagedIdentity_Example;

Console.WriteLine("Hello, World!");

string keyVaultUrl = "https://keyvaultexampleapp.vault.azure.net/";
string secretName = "ConnectionStringExampleApp";
KeyVaultHandler handler = new KeyVaultHandler(keyVaultUrl);
var secretClient = handler.GetSecretClient();
var mysecret = await secretClient.GetSecretAsync(secretName);
Console.WriteLine(mysecret.Value.Value);