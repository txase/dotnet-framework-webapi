using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;

namespace webapi.Data
{
    public static class webapiConnectionStringBuilder
    {
        private class Credentials
        {
            public string username = null;
            public string password = null;
        }

        private static string _connectionString;

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        static webapiConnectionStringBuilder()
        {
            var client = new AmazonSecretsManagerClient();
            var response = client.GetSecretValue(new GetSecretValueRequest
            {
                SecretId = "arn:aws:secretsmanager:us-east-1:394493744367:secret:/stackery-demo/dotnet-webapi/Database/SAUser-c7o175" //Environment.GetEnvironmentVariable("DATABASE_CREDENTIALS_SECRET_ARN")
            });

            var credentials = JsonConvert.DeserializeObject<Credentials>(response.SecretString);

            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "ddr2zfjrb5uzfv.cll8zwl89swl.us-east-1.rds.amazonaws.com", //Environment.GetEnvironmentVariable("DB_ADDRESS"),
                UserID = credentials.username,
                Password = credentials.password,
                InitialCatalog = "books"
            };

            _connectionString = builder.ToString();
        }
    }
}