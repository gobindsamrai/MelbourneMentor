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
    [Register ("TourCheckViewController")]
    partial class TourCheckViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TourDatacheck { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TourDatacheck != null) {
                TourDatacheck.Dispose ();
                TourDatacheck = null;
            }
        }
    }
}