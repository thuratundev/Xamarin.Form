using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.ViewModels;

namespace App1
{
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            this.BindingContext = new LogInPageViewModel(Navigation);

           
        }
    }
}
