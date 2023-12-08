# This application Connect with the Azure Keyvault using the Default Credentials and retrieve secrets


# Steps to run the app
   
    - Install package Azure.Identity in Visual Studio
    - Install package Azure.Security.KeyVaults.Secrets 

    - Create a KeyVault in Azure with the following settings
            Access Configuration > Permission Model > Vault Access Policy
    - Create a Secrets with the name "ConnectionStringExampleApp"
    - Make sure Visual studio is signed in with the same email as azure portal Microsoft Entra ID
    - Now if you run the console application from visual studio the KeyVault value should be displayed

# Steps to deply the console app as Web Jobs
    

    - Deploy the Console app as web jobs
    - Configure the access policy in KeyVault with the Identity produced at ConsoleApp deployment
    - Now if you run the application the KeyVault value should be displayed. 
    - The Output screen is given in the Output folder to demonstrate how the Webjobs shows the keyvault value.



