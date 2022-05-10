﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5
{
    public class ShellViewModel : ObservableObject
    {
        public AsyncRelayCommand GoToSettings { get; private set; }

        public ShellViewModel()
        {
            GoToSettings = new AsyncRelayCommand(async () => await Shell.Current.GoToAsync("SettingsPage"));
        }
    }
}
