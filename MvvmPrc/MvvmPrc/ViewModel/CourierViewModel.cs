using MvvmPrc.Model;
using MvvmPrc.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmPrc.ViewModel
{
     public class CourierViewModel
    {
        private INavigation navi;
        public CourierViewModel(INavigation navi)
        {
            this.navi = navi;
            BindCourierDate();
        }
        private List<Courier> _AreaDelivered;
        public List<Courier> AreaDelivered
        {
            set
            {
                _AreaDelivered = value;

            }
            get
            {
                return _AreaDelivered;
            }
        }
        private Courier _Courieritem;
        public Courier Courieritem
        {

            set
            {
                _Courieritem = value;
                navi.PushAsync(new CourierDetailsView(_Courieritem));
            }
            get
            {
                return _Courieritem;
            }
        }
        private void BindCourierDate()
        {
            _AreaDelivered = new List<Courier>();
            _AreaDelivered.Add(new Courier { CAreaName = "HSRLayout", CourierCount = 2 });
            _AreaDelivered.Add(new Courier { CAreaName = "SilkBoard", CourierCount = 3 });
            _AreaDelivered.Add(new Courier { CAreaName = "Electroniccity", CourierCount = 4 });
            _AreaDelivered.Add(new Courier { CAreaName = "KRPuram", CourierCount = 15 });
            _AreaDelivered.Add(new Courier { CAreaName = "ALLAreas", CourierCount = 30 });

        }
    }
}
