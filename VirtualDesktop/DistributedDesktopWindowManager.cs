﻿using System;
using System.Windows.Threading;
using DistributedDesktop.Controls.Windows;

namespace DistributedDesktop
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class DistributedDesktopWindowManager
	{
		private readonly VirtualApplicationWindow _applicationWindow;
		private readonly DispatcherTimer _timer;

		public DistributedDesktopWindowManager()
		{
			_applicationWindow = new VirtualApplicationWindow(7588);
			_applicationWindow.Show();

			_timer= new DispatcherTimer(DispatcherPriority.Send);
			_timer.Interval = TimeSpan.FromMilliseconds(16);
			_timer.Tick += TimerOnTick;
			_timer.Start();
		}

		private void TimerOnTick(object sender, EventArgs e)
		{
			_applicationWindow.Refresh();
		}
	}
}