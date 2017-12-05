using System.IO;
using System.Reflection;
using Common.Security;
using Microsoft.Xrm.Sdk.Client;

namespace DeXrm.Win.Tools
{
    internal enum ConectionType
    {
        Office365 = 8,
        Local = 7
    }

    public class ConnectionFile
    {
        public string Path { get; set; }
        public string Name { get; set; }
    }

    public class Conexion
    {
        public string domain;
        public string nameOrganization;
        private string organizationName;
        public string password;
        private int port;
        private string server;
        public string url;
        public string user;

        public string ConnectionString
        {
            get
            {
                switch (Type)
                {
                    case AuthenticationProviderType.ActiveDirectory:
                        return
                            $"Url={url};Domain={domain};Username={user};Password={password};authtype=AD";
                    default:
                        return
                            $"Url={url};Username={user};Password={password};authtype=Office365";
                }
            }
        }

        public string FileConfigurationPah =>
            $@"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\File Connection\connection.xml";

        public AuthenticationProviderType Type { get; set; }
    }

    public static class Encrypt
    {
        private const string initVector = "dexrmwintool_rmvp";
        public const string Phase = "dxrm_rmvp";

        private const int keysize = 256;

        public static string EncryptString(string plainText, string passPhrase)
        {
            Security.CypherPassWord = initVector;
            return Security.Encrypt(plainText, passPhrase);
        }

        public static string DecryptString(string cipherText, string passPhrase)
        {
            Security.CypherPassWord = initVector;
            return Security.Decrypt(cipherText, passPhrase);
        }
    }
}