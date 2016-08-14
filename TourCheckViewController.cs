
using System;

using UIKit;

namespace MelbourneMentor
{
	public partial class TourCheckViewController : UITableViewController
	{
		protected TourCheckViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "HorseRidding", "AirBallon", "Ferri", "Helicopter", "Skydiving" };
			TourDatacheck.Source = new TableSource(items, this);


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
