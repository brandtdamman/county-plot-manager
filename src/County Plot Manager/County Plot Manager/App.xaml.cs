using County_Plot_Manager.ViewModels;
using County_Plot_Manager.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace County_Plot_Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

		wndMain wnd;
		ViewModelMain vmm;

		public App()
		{
			App.Current.Startup += Current_Startup;
		}

		private void Current_Startup(object sender, StartupEventArgs e)
		{
			Rect positionAndSize = County_Plot_Manager.Properties.Settings.Default.MainWindowPosition;
			WindowState wState = County_Plot_Manager.Properties.Settings.Default.MainWindowState;
			wnd = new wndMain();
			vmm = new ViewModelMain();
			wnd.DataContext = vmm;

			wnd.Closing += Wnd_Closing;

			if ((positionAndSize.IsEmpty)
		|| (SystemParameters.VirtualScreenWidth < positionAndSize.Left)
		|| (SystemParameters.VirtualScreenHeight < positionAndSize.Top))
			{
				positionAndSize = new Rect(10, 10, 800, 600);
			}

			wnd.Left = positionAndSize.Left;
			wnd.Top = positionAndSize.Top;
			wnd.Width = positionAndSize.Width;
			wnd.Height = positionAndSize.Height;
			wnd.WindowState = wState;

			wnd.Show();
		}

		private void Wnd_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			County_Plot_Manager.Properties.Settings.Default.MainWindowPosition
				= new Rect(wnd.Left, wnd.Top, wnd.Width, wnd.Height);
			County_Plot_Manager.Properties.Settings.Default.MainWindowState = wnd.WindowState;
			County_Plot_Manager.Properties.Settings.Default.Save();
			App.Current.Shutdown();
		}
	}
}
