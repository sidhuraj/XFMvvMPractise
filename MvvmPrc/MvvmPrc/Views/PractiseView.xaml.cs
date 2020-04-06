using MvvmPrc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmPrc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PractiseView : TabbedPage
    {
        public PractiseView()
        {
            InitializeComponent();

            BindingContext = new PractiseViewModel();
            Children.Add(new Vechileview());
            Children.Add(new WorkerView());
            Children.Add(new CourierView());
        }
    }
}