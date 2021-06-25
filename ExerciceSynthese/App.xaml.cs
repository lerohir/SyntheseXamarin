using ExerciceSynthese.Services;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciceSynthese
{
	public partial class App : Application
	{
		private static SQLiteConnection _sQLiteConnection;
		public static SQLiteConnection SQLiteConnection
		{
			get
			{
				if (_sQLiteConnection == null)
					_sQLiteConnection = new DataBaseGetter().Get();
				return _sQLiteConnection;
			}
		}
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
