using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlotManager.UI.Styles.UserControls
{
	/// <summary>
	/// Interaction logic for MinMaxClose.xaml
	/// </summary>
	public partial class MinMaxClose : UserControl
	{
		private WindowState ws;
		private Window wnd;

		public MinMaxClose()
		{
			InitializeComponent();
		}


		private void Minimize(object sender, RoutedEventArgs e)
		{
			wnd.WindowState = WindowState.Minimized;
		}


		private void MaxOrRestore(object sender, RoutedEventArgs e)
		{
			ws = wnd.WindowState;

			if (ws == WindowState.Maximized)
			{
				wnd.WindowState = WindowState.Normal;
			}
			else
			{
				wnd.WindowState = WindowState.Maximized;
			}

			ws = wnd.WindowState;
			DisplayMaxOrRestore();
		}


		private void DisplayMaxOrRestore()
		{
			if (ws == WindowState.Maximized)
			{
				button_Max.Visibility = Visibility.Collapsed;
				button_Restore.Visibility = Visibility.Visible;
			}
			else
			{
				button_Max.Visibility = Visibility.Visible;
				button_Restore.Visibility = Visibility.Collapsed;
			}
		}

		private void CloseWindow(object sender, RoutedEventArgs e)
		{
			SystemCommands.CloseWindow(Window.GetWindow((Button)sender));
		}

		private void _OnSystemCommandCloseWindow(object sender, ExecutedRoutedEventArgs e)
		{
			SystemCommands.CloseWindow((Window)e.Parameter);
		}


		/// <summary>
		/// Determines the window state and sets the appropriate button
		/// to visible when the usercontrol is loaded.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserControlLoaded(object sender, RoutedEventArgs e)
		{
			if (Window.GetWindow(this) != null)
			{
				wnd = Window.GetWindow(this);
				ws = wnd.WindowState;
				DisplayMaxOrRestore();
			}
		}



	}
}
