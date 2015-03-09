using System;
using System.ComponentModel;

namespace CS_Demo_Manager.Model
{
	public class Demo : INotifyPropertyChanged
	{
		private string _name;
		private DateTime _creationDate;
		private DateTime _lastModificationDate;
		private int _protocol;
		private int _netProtocol;
		private string _serverName;
		private string _clientName;
		private string _mapName;
		private string _gameDirectory;
		private float _playbackTime;
		private int _ticks;
		private int _frames;
		private int _signonLength;

		public Demo()
		{
		}

		public Demo(string name, int protocol, int netProtocol, string serverName, string clientName, string mapName,
			string gameDirectory, float playbackTime, int ticks, int frames, int signonLength, DateTime creationDate,
			DateTime lastModificationDate)
		{
			_name = name;
			_protocol = protocol;
			_netProtocol = netProtocol;
			_serverName = serverName;
			_clientName = clientName;
			_mapName = mapName;
			_gameDirectory = gameDirectory;
			_playbackTime = playbackTime;
			_ticks = ticks;
			_frames = frames;
			_signonLength = signonLength;
			_creationDate = creationDate;
			_lastModificationDate = lastModificationDate;
		}

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				NotifyPropertyChanged("Name");
			}
		}

		public DateTime CreationDate
		{
			get { return _creationDate; }
			set
			{
				_creationDate = value;
				NotifyPropertyChanged("CreationDate");
			}
		}

		public DateTime LastModificationDate
		{
			get { return _lastModificationDate; }
			set
			{
				_lastModificationDate = value;
				NotifyPropertyChanged("LastModificationDate");
			}
		}

		public int Protocol
		{
			get { return _protocol; }
			set
			{
				_protocol = value;
				NotifyPropertyChanged("Protocol");
			}
		}

		public int NetProtocol
		{
			get { return _netProtocol; }
			set
			{
				_netProtocol = value;
				NotifyPropertyChanged("NetProtocol");
			}
		}

		public string ServerName
		{
			get { return _serverName; }
			set
			{
				_serverName = value;
				NotifyPropertyChanged("ServerName");
			}
		}

		public string ClientName
		{
			get { return _clientName; }
			set
			{
				_clientName = value;
				NotifyPropertyChanged("ClientName");
			}
		}

		public string MapName
		{
			get { return _mapName; }
			set
			{
				_mapName = value;
				NotifyPropertyChanged("MapName");
			}
		}

		public string GameDirectory
		{
			get { return _gameDirectory; }
			set
			{
				_gameDirectory = value;
				NotifyPropertyChanged("GameDirectory");
			}
		}

		public float PlaybackTime
		{
			get { return _playbackTime; }
			set
			{
				_playbackTime = value;
				NotifyPropertyChanged("PlaybackTime");
			}
		}

		public int Ticks
		{
			get { return _ticks; }
			set
			{
				_ticks = value;
				NotifyPropertyChanged("Ticks");
			}
		}

		public int Frames
		{
			get { return _frames; }
			set
			{
				_frames = value;
				NotifyPropertyChanged("Frames");
			}
		}

		public int SignonLength
		{
			get { return _signonLength; }
			set
			{
				_signonLength = value;
				NotifyPropertyChanged("SignonLength");
			}
		}

		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}