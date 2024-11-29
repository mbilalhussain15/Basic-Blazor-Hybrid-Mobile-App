using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject1.States
{
    public class AppState
    {
        public event EventHandler<string> SelectedMenuItemChanged;
        public string SelectedMenuItem { get; private set; } = AppConstants.MeniItems.Home;
        public string PageTitle => SelectedMenuItem switch
        {
            AppConstants.MeniItems.Home => AppConstants.AppName,
            _ => SelectedMenuItem
        };
        public void setSelectedMenuItem(string pageName)
        {
            SelectedMenuItem = pageName;
            SelectedMenuItemChanged?.Invoke(this, pageName);
        }

    }
}
