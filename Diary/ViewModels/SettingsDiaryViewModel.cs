using Diary.Commands;
using Diary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Diary.ViewModels
{
    public class SettingsDiaryViewModel : ViewModelBase
    {
        private UserSettings _userSettings;
        private readonly bool _canCloseWindow;

        public SettingsDiaryViewModel(bool canCloseWindow)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);
            _userSettings = new UserSettings();
            _canCloseWindow = canCloseWindow;
        }

        
        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }
        public UserSettings UserSettings 
        { 
            get
            {
                return _userSettings;
            }
            set
            { 
                _userSettings = value;
                OnPropertyChanged();
            }
        }
        private void Confirm(object obj)
        {
            if (!UserSettings.IsValid)
                return;

            UserSettings.Save();
            RestartApplication();

        }

        private void RestartApplication()
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Close(object obj)
        {
            if (_canCloseWindow)
                CloseWindow(obj as Window);
            else
                Application.Current.Shutdown();

            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
