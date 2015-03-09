using System;
using System.Collections.ObjectModel;
using CS_Demo_Manager.Model;
using GalaSoft.MvvmLight;

namespace CS_Demo_Manager.ViewModels
{
	public class HomeViewModel : ViewModelBase
	{
		public ObservableCollection<Demo> Demos { get; set; }

		public HomeViewModel()
		{
			Demos = new ObservableCollection<Demo>();
			for (var i = 0; i < 10; i++)
			{
				var demo = new Demo("Demo" + i,
					1,
					2,
					"192.168.0." + i + ":2700" + i,
					"Civilian",
					"de_dust2",
					"directory",
					100 + i,
					180000 + i,
					180001 + i,
					1,
					new DateTime(),
					new DateTime());
				Demos.Add(demo);
			}
		}
	}
}