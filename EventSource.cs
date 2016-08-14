using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;

namespace MelbourneMentor
{

	public class EventSource : UITableViewController
	{
		protected string[] tableItems;
		protected string cellIdentifier = "TableCell";
		UITableViewController owner;

		public EventSource(string[] items, UITableViewController owner)
		{
			tableItems = items;
			this.owner = owner;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			UIAlertController alertController = UIAlertController.Create("Selected Event", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			owner.PresentViewController(alertController, true, null);

			UIApplication.SharedApplication.OpenUrl(new NSUrl("https://www.google.com/#q=" + tableItems[indexPath.Row]));

			tableView.DeselectRow(indexPath, true);
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			//request a recycled cell to save memory
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

			//if there are no cell to reuse, create a newone
			if (cell == null)
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);

			cell.TextLabel.Text = tableItems[indexPath.Row];

			return cell;
		}

		public static implicit operator UITableViewSource(EventSource v)
		{
			throw new NotImplementedException();
		}
	}
}
