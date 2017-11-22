﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OwnRadio.Client.Desktop.ViewModel;

namespace OwnRadio.Client.Desktop
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static OwnRadioClient OwnRadioClient { get; private set; } = new OwnRadioClient();

		/// <summary>
		/// Event handler fired then application started
		/// Generate new DeviceID if needed and save it to user's configuartion
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			//
			// Check if we already generate DeviceId
			if (Desktop.Properties.Settings.Default.DeviceId == Guid.Empty)
			{
				Desktop.Properties.Settings.Default.DeviceId = Guid.NewGuid();
				Desktop.Properties.Settings.Default.Save();
			}
		}
	}
}