using System.Windows.Controls;
using System.Windows.Media;
using CS_Demo_Manager.ViewModels;

namespace CS_Demo_Manager.Views
{
	/// <summary>
	/// Interaction logic for Home.xaml
	/// </summary>
	public partial class Home : UserControl
	{
		public Home()
		{
			InitializeComponent();

			if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				Background = Brushes.Transparent;
			}

			// create and assign the appearance view model
			DataContext = new HomeViewModel();
		}
	}
}