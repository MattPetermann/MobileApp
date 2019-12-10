using System;
using System.Collections.Generic;
using System.Windows.Input;
using Final.Models;
using Xamarin.Forms;

namespace Final.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
            Title = "Settings";
        }

        public List<Setting> SettingsList =>
            new List<Setting>
            {
                new Setting()
                {
                    Name = "High Contrast Mode",
                    Identifier = "HighContrastSetting"
                }
            };
    }
}