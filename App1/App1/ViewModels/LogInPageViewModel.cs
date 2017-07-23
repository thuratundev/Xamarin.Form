using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class LogInPageViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }

        private ICommand _submitCommand;
        public ICommand SubmitCommand
        {
            get { return _submitCommand; }
            set { _submitCommand = value; }
        }

        private string _userName;

        public string userName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
                
            }
        }

        private string _passWord;

        public string passWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
                OnPropertyChanged();
            }
        }


        private string _IconFont;

        public string IconFont
        {
            get { return _IconFont; }
            set { _IconFont = value; }
        }





        public LogInPageViewModel(INavigation navigation)
        {
            IconFont = "";
            this.Navigation = navigation;
            SubmitCommand = new Command(async() =>await ExecuteLogin());
        }

        private async Task ExecuteLogin()
        {
            if(passWord== "admin" && userName =="admin")
            {
                await Navigation.PushModalAsync(new App1.Views.MainConsolePage());
            }

        }
    }
}
