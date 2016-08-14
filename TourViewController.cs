using Foundation;
using System;
using UIKit;

namespace MelbourneMentor
{
    public partial class TourViewController : UITableViewController
    {
		public TourViewController(IntPtr handle) : base(handle)
		{
		}
			

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "HorseRidding", "AirBallon", "Ferri", "Helicopter", "Skydiving"};
			TourData.Source = new TourSource(items, this);


        }

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use
		}
    }
}



