using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramClone.LoginPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            LanguagePicker.SelectedItem = "English (United States)";
        }

        private void VerificaEntradas(object sender, TextChangedEventArgs e)
        {
            if(EntryLogin.Text == null || EntryLogin.Text == "" || EntryPassword.Text == null || EntryPassword.Text == "")
            {
                ButtonLogin.BackgroundColor = Color.FromHex("#002D4A");
                ButtonLogin.TextColor = Color.FromHex("#7A7A7A");
            }
            else
            {
                ButtonLogin.BackgroundColor = Color.FromHex("#0095F6");
                ButtonLogin.TextColor = Color.FromHex("#FFFFFF");
            }
        }

        private void EventShowPassword(object sender, EventArgs e)
        {
            EntryPassword.IsPassword = !EntryPassword.IsPassword;
            if (EntryPassword.IsPassword)
            {
                ShowPasswordImage.Source = "ShowPasswordGray.png";
            }
            else
            {
                ShowPasswordImage.Source = "ShowPasswordBlue.png";
            }
        }

        private void DoLogin(object sender, EventArgs e)
        {
            if(ButtonLogin.BackgroundColor == Color.FromHex("#0095F6"))
            {
                App.Current.MainPage = new NavigationPage(new Pages.Home());
            }
        }
    }
}