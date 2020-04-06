using MvvmPrc.Model;
using MvvmPrc.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmPrc.ViewModel
{
     public class VechileViewModel
    {
        private INavigation navi;
        public VechileViewModel(INavigation navi)
        {
            this.navi = navi;
            bindVechileData();
        }
        private List<Vechiles> _TopVechiles;
        public List<Vechiles> TopVechiles
        {
            set
            {
                _TopVechiles = value;
            }
            get
            {
                return _TopVechiles;
            }
        }
        private Vechiles _Vechileitem;
        public Vechiles Vechileitem
        {
            set
            {
                _Vechileitem = value;

                navi.PushAsync(new VechilesDetailsPage(_Vechileitem));

            }
            get
            {
                return _Vechileitem;
            }
        }

        private void bindVechileData()
        {
            _TopVechiles = new List<Vechiles>();
            _TopVechiles.Add(new Vechiles { VName = "Maruthi suzuki VDI-petrol", VNumber = "AP31DQ1234"});
            _TopVechiles.Add(new Vechiles { VName = "Ford f-150 Raptor", VNumber = "AP31DQ1235" });
            _TopVechiles.Add(new Vechiles { VName = "Volkswagen beetle", VNumber = "AP31DQ1236" });
            _TopVechiles.Add(new Vechiles { VName = "McLaren senna", VNumber = "AP31DQ1237" });
            _TopVechiles.Add(new Vechiles { VName = "Triumph splitfire", VNumber = "AP31DQ1238" });

        }
    }
}
