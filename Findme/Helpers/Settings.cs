using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Findme.Helpers
{
    public enum LoginAccount
    {
        None    = 0,
        Email   = 1,
        Facebook = 2,
        Twitter = 3,
        Windows = 4
    }


    public class Settings : INotifyPropertyChanged
    {
        const string LoginAccountKey = "login_account";
        bool isConnected;

        static Settings _settings;

        public event PropertyChangedEventHandler PropertyChanged;

      //   static ISettings AppSettings => CrossSettings.Current;

      //  public bool IsLoggedIn
        //    => !string.IsNullOrWhiteSpace(AuthToken) && !string.IsNullOrWhiteSpace(AzureMobileUserId);


        // public LoginAccount LoginAccount
        // {
        //  get { return (LoginAccount)AppSettings.GetValueOrDefault(LoginAccountKey, (int)LoginAccountDefault); }
        //  set
        //  {
        //      if (AppSettings.AddOrUpdateValue(LoginAccountKey, (int)value))
        //          OnPropertyChanged();
        //  }
        //}

        public bool IsConnected
        {
            get { return isConnected; }
            set
            {
                if (isConnected == value)
                    return;
                isConnected = value;
          //      OnPropertyChanged();
            }
        }

       // public string AuthToken
       // {
         //   get { return AppSettings.GetValueOrDefault(AuthTokenKey, AuthTokenDefault); }
         //   set { AppSettings.AddOrUpdateValue(AuthTokenKey, value); }
       // }

        public void Logout()
        {
          //  AuthToken = string.Empty;
         //   UserProfileUrl = string.Empty;
         //   UserFirstName = string.Empty;
         //   UserLastName = string.Empty;
         //   AzureMobileUserId = string.Empty;
         //   UserUID = string.Empty;
          //  LoginAccount = LoginAccount.None;
        }

    }

}