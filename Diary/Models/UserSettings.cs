using Diary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Models
{
    public class UserSettings : IDataErrorInfo
    {
        private bool _isServerAddressValid;
        private bool _isServerNameValid;
        private bool _isDatabaseValid;
        private bool _isUserValid;
        private bool _isPasswordValid;


        public string ServerAddress
        {
            get
            {
                return Settings.Default.ServerAddress;
            }
            set
            {
                Settings.Default.ServerAddress = value;
            }
        }
        public string ServerName
        {
            get
            {
                return Settings.Default.ServerName;
            }
            set
            {
                Settings.Default.ServerName = value;
            }
        }
        public string Database
        {
            get
            {
                return Settings.Default.Database;
            }
            set
            {
                Settings.Default.Database = value;
            }
        }
        public string User
        {
            get
            {
                return Settings.Default.User;
            }
            set
            {
                Settings.Default.User = value;
            }
        }
        public string Password
        {
            get
            {
                return Settings.Default.Password;
            }
            set
            {
                Settings.Default.Password = value;
            }
        }


        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(ServerAddress):
                        if (string.IsNullOrWhiteSpace(ServerAddress))
                        {
                            Error = "Pole jest wymagane.";
                            _isServerAddressValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerAddressValid = true;
                        }
                        break;

                    case nameof(ServerName):
                        if (string.IsNullOrWhiteSpace(ServerAddress))
                        {
                            Error = "Pole jest wymagane.";
                            _isServerNameValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isServerNameValid = true;
                        }
                        break;

                    case nameof(Database):
                        if (string.IsNullOrWhiteSpace(ServerAddress))
                        {
                            Error = "Pole jest wymagane.";
                            _isDatabaseValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isDatabaseValid = true;
                        }
                        break;

                    case nameof(User):
                        if (string.IsNullOrWhiteSpace(ServerAddress))
                        {
                            Error = "Pole jest wymagane.";
                            _isUserValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isUserValid = true;
                        }
                        break;

                    case nameof(Password):
                        if (string.IsNullOrWhiteSpace(ServerAddress))
                        {
                            Error = "Pole jest wymagane.";
                            _isPasswordValid = false;
                        }
                        else
                        {
                            Error = string.Empty;
                            _isPasswordValid = true;
                        }
                        break;
                    default:
                        break;
                }
                return Error;
            }
        }
        public string Error { get; set; }

        public bool IsValid
        {
            get
            {
                return _isServerAddressValid && _isServerNameValid && _isPasswordValid && 
                    _isDatabaseValid && _isUserValid;
            }
        }

        public void Save()
        {
            Settings.Default.Save();
        }
    }
}
