using System.Threading.Tasks;

namespace DeXrm.Win.Tools
{
    public class ControllerFrmQuery : IControllerFrmQuery
    {
        private readonly IModelFrmQuery _model;
        private readonly IFrmQuery _view;

        public ControllerFrmQuery(IFrmQuery view, IModelFrmQuery model)
        {
            _view = view;
            _model = model;
            _view.setController(this);
        }

        public async void GetEntities()
        {
            var retorno = Task.Run(() => GetEntitiesAsyn());
            var x = await retorno;
            if (x)
            {
                _view.SetEntities(_model);
                _view.Message();
            }
        }

        private bool GetEntitiesAsyn()
        {
            //_model.ServerConfiguration = _view.ServerConnection.configurations[0];
            _model.GetMetaEntity();
            return true;
        }
    }
}