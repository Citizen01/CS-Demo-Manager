using System.Windows.Controls;
using System.Windows.Media;

namespace CS_Demo_Manager.Views
{
	/// <summary>
	/// Interaction logic for SettingsPage.xaml
	/// </summary>
	public partial class SettingsPage : UserControl
	{
		public SettingsPage()
		{
			InitializeComponent();

			if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				Background = Brushes.Transparent;
			}
		}
	}
}