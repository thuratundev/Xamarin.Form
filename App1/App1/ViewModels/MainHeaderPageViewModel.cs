using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    class MainHeaderPageViewModel : ViewModelBase
    {
        private string _mainText;

        private ObservableCollection<Contents> _contentobj;

        public ObservableCollection<Contents> contentobj
        {
            get { return _contentobj; }
            set
            {
                _contentobj = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> _contentitem;

        public ObservableCollection<string> contentitem
        {
            get { return _contentitem; }
            set
            {
                _contentitem = value;
                OnPropertyChanged();
            }
        }


        public string MainText
        {
            get { return _mainText; }
            set
            {
                _mainText = value;
                OnPropertyChanged();
            }
        }



        public MainHeaderPageViewModel()
        {
            MainText = "Header";
            contentobj = new ObservableCollection<Contents>();
            contentobj.Add(new Contents { ContentId = 1, ContentName = "Course" });
            contentobj.Add(new Contents { ContentId = 2, ContentName = "Events" });

            contentitem = new ObservableCollection<string>();
            foreach(Contents content in contentobj)
            {
                contentitem.Add(content.ContentName);
            }
        }


    }
}
