// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MelbourneMentor
{
    [Register ("TourViewController")]
    partial class TourViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TourData { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TourData != null) {
                TourData.Dispose ();
                TourData = null;
            }
        }
    }
}