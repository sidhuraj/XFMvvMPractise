using MvvmPrc.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmPrc.ViewModel
{
     public class CourierDetailsViewModel
    {
        public CourierDetailsViewModel(Courier Courieritem)
        {
            _CourierPage = Courieritem.CAreaName;
        }
        private string _CourierPage;
        public string CourierPage
        {
            set
            {
                _CourierPage = value;
            }
            get
            {
                return _CourierPage;
            }
        }
    }
}
