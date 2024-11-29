using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject1
{
    public class MauiInterop
    {
        private readonly AppViewModel _appViewModel;

        public MauiInterop(AppViewModel appViewModel)
        {
            _appViewModel = appViewModel;
        }
        public void ShowLoader() => _appViewModel.ToggleIsLoadingBusy(true);
        public void HideLoader() => _appViewModel.ToggleIsLoadingBusy(false);

        public async Task ShowErrorAlertAsync(string message, string? title = "Error") =>
            await App.Current.MainPage.DisplayAlert(title, message, "OK");

        public async Task ShowSuccessAlertAsync(string message, string? title = "Success") =>
            await App.Current.MainPage.DisplayAlert(title, message, "OK");

        public bool IsAndroid => DeviceInfo.Current.Platform == DevicePlatform.Android;
        public bool IsIOS => DeviceInfo.Current.Platform == DevicePlatform.iOS;

    }
}
