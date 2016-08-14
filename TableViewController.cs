
using System;

using UIKit;

namespace MelbourneMentor
{
	public partial class TableViewController : UITableViewController
	{
		protected TableViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] items = new string[] { "MelbourneCentral","EmporiumMelbourne", "SouthWharf","SpencerOutlet", "Chadstone","HighPoint" };
			TableData.Source = new TableSource(items, this);


		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
