using DeXrm.Win.Tools.Models;
using DeXrm.Win.Tools.Views;

namespace DeXrm.Win.Tools.Controllers
{
    public class ControllersFrmTrace : IControllersFrmTrace
    {
        private readonly IModelTrace _model;
        private readonly IViewTraceSetting _view;

        public ControllersFrmTrace(IViewTraceSetting view, IModelTrace model)
        {
            _view = view;
            _model = model;
            _view.SetController(this);
        }

        public void ChangeRegedit()
        {
            _model.RegeditObject = _view.RegeditObject;
            _model.ChangeRegedit();
        }
    }
}