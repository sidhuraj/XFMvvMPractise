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
    public partial class CourierView : ContentPage
    {
        public CourierView()
        {
            InitializeComponent();
            BindingContext = new CourierViewModel(Navigation);
        }
    }
}