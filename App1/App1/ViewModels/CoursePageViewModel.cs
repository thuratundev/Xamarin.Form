using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    class CoursePageViewModel : ViewModelBase
    {
        private string _CourseTitle;

        public string CourseTitle
        {
            get { return _CourseTitle; }
            set
            {
                _CourseTitle = value;
                OnPropertyChanged();
            }
        }

        public CoursePageViewModel()
        {
            CourseTitle = "ComputerSciences";
        }

    }
}
