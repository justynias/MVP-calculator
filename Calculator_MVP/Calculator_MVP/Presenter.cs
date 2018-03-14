using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MVP
{
    public class Presenter
    {
        IView view;
        Model model;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.ViewEvent += View_ViewEvent;
        }

        private double View_ViewEvent(object sender, EventArgs e)
        {
            
            return model.GetResult(view.Value1, view.Operator);

        }
    }
}
