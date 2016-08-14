
using System;

using UIKit;

namespace MelbourneMentor
{
	public partial class EventViewController: UITableViewController
	{
		protected EventViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "Events", "Festivals", "Live Concerts", "Movies", "Circus", "Racing" };
			EventData.Source = new TableSource(items, this);


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
