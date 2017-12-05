namespace DeXrm.Win.Tools.Models
{
    //using Microsoft.Crm.Sdk.Helper;
    using System;
    using Object;
    using Datos;


    public class ModelsFrmLogon : SuperBase, IModelsFrmLogon
    {

        public Boolean SaveConfig()
        {
            var obj = SetObject(this);
            Datos.Configuration.SaveConfiguration(obj);
            return true;
        }

        public void SetConfiguration()
        {
           // this.ServerConnection = OrganizationData.GetObjectConnection(this.Configuration.SavedConfig);
        }

        public void GetConfigSaved()
        {
            this.File = Util.GetConfigSaved();
        }

        public void RetrieveOrganization()
        {
            this.OrganizationObjects = new OrganizationData().GetAllOrganization(this.Configuration.SavedConfig);
            new Util().UpdateConfigFile(this.Configuration.SavedConfig,this.OrganizationObjects[0].OrganizationUri.ToString(), "Uri");
            new Util().UpdateConfigFile(this.Configuration.SavedConfig, this.OrganizationObjects[0].FriendlyName, "Org");
        }

        public void IsExist()
        {
            this.Exist = new OrganizationData().IsExist(this.Configuration.SavedConfig);
        }

        private DeXrm.Win.Object.Configuration SetObject(ModelsFrmLogon modelsFrm)
        {
            var objConfiguration = new DeXrm.Win.Object.Configuration()
            {
                Domain = modelsFrm.Configuration.Domain,
                Password = modelsFrm.Configuration.Password,
                UrlServer = modelsFrm.Configuration.UrlServer,
                User = modelsFrm.Configuration.User,
                TypeConnection =  modelsFrm.Configuration.TypeConnection,
                IsTemplate = modelsFrm.Configuration.IsTemplate,
                SavedConfig = modelsFrm.Configuration.SavedConfig,
                IsOnline = modelsFrm.Configuration.IsOnline,
                Organization = modelsFrm.Configuration.Organization,
                InternalUser = modelsFrm.Configuration.InternalUser,
                SecurityUrl = modelsFrm.Configuration.SecurityUrl,
                NameServer = modelsFrm.Configuration.NameServer,
                DefaultUrl = modelsFrm.Configuration.DefaultUrl
            };
            return objConfiguration;
        }

        /// <summary>
        /// Objeto para poder enviarlo al Main
        /// </summary>
        //public ServerConnection ServerConnection { get; set; }  
    }
}
