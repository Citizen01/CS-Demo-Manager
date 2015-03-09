using System.Windows.Controls;
using System.Windows.Media;

namespace CS_Demo_Manager.Views.Settings
{
	/// <summary>
	/// Interaction logic for Appearance.xaml
	/// </summary>
	public partial class Appearance : UserControl
	{
		public Appearance()
		{
			InitializeComponent();

			if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				Background = Brushes.Transparent;
			}
		}
	}
}