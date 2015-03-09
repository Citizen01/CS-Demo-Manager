using System.Windows.Controls;
using System.Windows.Media;

namespace CS_Demo_Manager.Views.Settings
{
	/// <summary>
	/// Interaction logic for About.xaml
	/// </summary>
	public partial class About : UserControl
	{
		public About()
		{
			InitializeComponent();

			if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				Background = Brushes.Transparent;
			}
		}
	}
}