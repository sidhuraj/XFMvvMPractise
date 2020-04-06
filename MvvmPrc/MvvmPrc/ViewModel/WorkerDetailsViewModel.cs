using MvvmPrc.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmPrc.ViewModel
{
     public class WorkerDetailsViewModel
    {
        public WorkerDetailsViewModel(Workers Workeritem)
        {
            _WorkerPage = Workeritem.Wname;

        }
        private string _WorkerPage;
        public string WorkerPage
        {
            set
            {
                _WorkerPage = value;
            }
            get
            {
                return _WorkerPage;
            }
        }
    }
}
