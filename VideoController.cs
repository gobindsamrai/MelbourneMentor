using Foundation;
using System;
using UIKit;
using MediaPlayer;

namespace MelbourneMentor
{
    public partial class VideoController : UIViewController
    {

		MPMoviePlayerController moviePlayer;
		partial void UIButton1790_TouchUpInside(UIButton sender)
		{

			{
				moviePlayer = new MPMoviePlayerController(NSUrl.FromFilename("video.mp4"));
				View.AddSubview(moviePlayer.View);
				moviePlayer.SetFullscreen(true, true);
				moviePlayer.Play();
			};
			
		}

		public VideoController (IntPtr handle) : base (handle)
        {
        }
    }
}