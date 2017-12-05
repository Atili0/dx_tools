﻿namespace DeXrm.Win.Tools.Controllers
{
    using System;
    using Object;
    using Models;
    using Views;

    public class ControllersFrmLogon : IControllersFrmLogon
    {
        private readonly IModelsFrmLogon _model;
        private readonly IViewFrmLogon _view;

        public ControllersFrmLogon(IViewFrmLogon view, IModelsFrmLogon model)
        {
            _view = view;
            _model = model;
            _view.setController(this);
        }

        public void GetConfigSaved()
        {
            _model.GetConfigSaved();
            _view.SetConfigSaved(_model);
        }

        public void DisableField()
        {
            _view.DisableField();
        }

        public void EnableField()
        {
            _view.EnableField();
        }

        public void RetrieveOrganization()
        {
            _model.RetrieveOrganization();
            _view.SetOrganization(_model);
        }

        public void GetUrlServer()
        {
            switch (_view.TypeConnection)
            {
                case "ActiveDirectory":
                case "Federation":
                case "OnlineFederation":
                    _view.EnableServerField();
                    _view.UrlServer = "";
                    break;
                case "LiveId":
                    _view.DisableServerField();
                    _view.UrlServer = "crm4.dynamics.com";
                    break;
            }
        }

        public void GenerateConfig()
        {
            UpdateObject(_model);
            _model.IsExist();

            if (!String.IsNullOrEmpty(_view.SavedConfig) && _model.Exist)
            {
                _model.RetrieveOrganization();
                _model.SetConfiguration();
                _view.SetOrganization(_model);
            }
            else
            {
                _model.SaveConfig();    
            }
        }

        public void SetConfiguration()
        {
            _model.SetConfiguration();
            _view.SetConfiguration(_model);
        }

        private void UpdateObject(IModelsFrmLogon model)
        {
            model.Configuration = new Configuration
            {
                User = _view.User,
                Domain = _view.Domain,
                Password = _view.Password,
                UrlServer = String.Format("{0}{1}", _view.TypeUrl, _view.UrlServer),
                TypeConnection = _view.TypeConnection,
                InternalUser = _view.InternalUser,
                IsTemplate = _view.IsTemplate,
                SavedConfig = _view.SavedConfig,
                IsOnline = _view.IsOnline,
                SecurityUrl= _view.TypeUrl,
                NameServer = _view.UrlServer,
                DefaultUrl = _view.UrlServer
            };
        }
    }
}
