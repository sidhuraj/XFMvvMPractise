using MvvmPrc.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmPrc.ViewModel
{
     public class VechilesDetailViewModel
    {
       
        public VechilesDetailViewModel(Vechiles Vechileitem)
        {
            _PageName = Vechileitem.VName;
        }
        private string _PageName;
        public string PageName
        {
            set
            {
                _PageName = value;
            }
            get
            {
                return _PageName;
            }
        }
    }
}
