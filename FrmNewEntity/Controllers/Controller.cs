using DeXrm.Win.Tools.FrmNewEntity.Models;
using DeXrm.Win.Tools.FrmNewEntity.View;

namespace DeXrm.Win.Tools.FrmNewEntity.Controllers
{
    public class Controller : IControllerNewEntity
    {
        private readonly IModelNewEntity _model;
        private readonly IFrmNewEntity _view;

        public Controller(IFrmNewEntity view, IModelNewEntity model)
        {
            _view = view;
            _model = model;
            _view.SetController(this);
        }
    }
}