/*
  In App.xaml:
  <Application.Resources>
	  <vm:ViewModelLocator xmlns:vm="clr-namespace:CS_Demo_Manager"
						   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CS_Demo_Manager.ViewModels.Settings;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace CS_Demo_Manager.ViewModels
{
	/// <summary>
	/// This class contains static references to all the view models in the
	/// application and provides an entry point for the bindings.
	/// </summary>
	public class ViewModelLocator
	{
		/// <summary>
		/// Initializes a new instance of the ViewModelLocator class.
		/// </summary>
		public ViewModelLocator()
		{
			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			//if (ViewModelBase.IsInDesignModeStatic)
			//{
			//    // Create design time view services and models
			//    SimpleIoc.Default.Register<IDataService, DesignDataService>();
			//}
			//else
			//{
			//    // Create run time view services and models
			//    SimpleIoc.Default.Register<IDataService, DataService>();
			//}

			SimpleIoc.Default.Register<HomeViewModel>();
			SimpleIoc.Default.Register<AppearanceViewModel>();
		}

		public HomeViewModel Home
		{
			get { return ServiceLocator.Current.GetInstance<HomeViewModel>(); }
		}

		public AppearanceViewModel Appearance
		{
			get { return ServiceLocator.Current.GetInstance<AppearanceViewModel>(); }
		}

		public static void Cleanup()
		{
			// TODO Clear the ViewModels
		}
	}
}