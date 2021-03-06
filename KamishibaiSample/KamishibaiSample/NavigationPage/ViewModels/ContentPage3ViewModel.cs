﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kamishibai.Xamarin.Forms;
using Kamishibai.Xamarin.Forms.Mvvm;

namespace KamishibaiSample.NavigationPage.ViewModels
{
    public class ContentPage3ViewModel : IPageLifecycleAware, IApplicationLifecycleAware
    {
        public NavigationRequestCommand RequestPopToRoot { get; } = new NavigationRequestCommand();
        public NavigationRequestCommand RequestRemoveContentPage1 { get; } = new NavigationRequestCommand();
        public NavigationRequestCommand RequestRemoveThis { get; } = new NavigationRequestCommand();
        public void OnInitialize()
        {
            WriteLog();
        }

        public void OnLoaded()
        {
            WriteLog();
        }

        public void OnUnloaded()
        {
            WriteLog();
        }

        public void OnClosed()
        {
            WriteLog();
        }
        public void OnResume()
        {
            WriteLog();
        }

        public void OnSleep()
        {
            WriteLog();
        }

        private void WriteLog(object param = null, [CallerMemberName] string name = null)
        {
            Debug.WriteLine($"{GetType().Name}${name}({param})");
        }
    }
}
