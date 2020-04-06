using MvvmPrc.Model;
using MvvmPrc.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmPrc.ViewModel
{
    public class WorkerViewModel
    {
        private INavigation navi;
        public WorkerViewModel(INavigation navi)
        {
            this.navi = navi;
            bindWorkersData();
        }
        private List<Workers> _WorkersDrived;

        public List<Workers> WorkersDrived
        {
            set
            {
                _WorkersDrived = value;
            }
            get
            {
                return _WorkersDrived;
            }
        }
        private Workers _Workeritem;
        public Workers Workeritem
        {
            set
            {
                _Workeritem = value;
                navi.PushAsync(new WorkerdetailsView(_Workeritem));
            }
            get
            {
                return _Workeritem;
            }
        }

        private void bindWorkersData()
        {
        _WorkersDrived = new List<Workers>();
        _WorkersDrived.Add(new Workers { Wname = "Srinu",  Drived = "Maruthi suzuki VDI-petrol" });
        _WorkersDrived.Add(new Workers { Wname = "Raju", Drived = "Ford f-150 Raptor" });
        _WorkersDrived.Add(new Workers { Wname = "Ram", Drived = "Volkswagen beetle" });
        _WorkersDrived.Add(new Workers { Wname = "Rajesh", Drived = "McLaren senna" });
        _WorkersDrived.Add(new Workers { Wname = "Rajam", Drived = "Triumph splitfire" });


        }
    }
}
