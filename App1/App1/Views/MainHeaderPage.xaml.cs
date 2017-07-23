using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.ViewModels;
using Xamarin.Forms.Pages;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class MainHeaderPage : ContentPage
    {
        public MainHeaderPage()
        {
            InitializeComponent();
            this.BindingContext = new MainHeaderPageViewModel();
        }
    }
}
