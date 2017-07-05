using System;
using AVFoundation;
using Foundation;
using UIKit;

namespace XamariniOSAVAudioPlayer
{
	public partial class ViewController : UIViewController
	{
		//public values
		public AVAudioPlayer player;
		public float MusicVolume { get; set; } = 0.5f;
		public bool MusicOn { get; set; } = true;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}
		partial void BtnStop_TouchUpInside(UIButton sender)
		{
			//Backgroundmusic stop
			player.Stop();
		}
		partial void BtnPlay_TouchUpInside(UIButton sender)
		{
			//call PlayMusic method
			PlayMusic();
		}
		public void PlayMusic()
		{
			NSUrl songURL;
			if (!MusicOn) return;

			//Song url from your local Resource
			songURL = new NSUrl("Sounds/song.mp3");
			NSError err;
			player = new AVAudioPlayer(songURL, "Song", out err);
			player.Volume = MusicVolume;
			player.FinishedPlaying += delegate
			{
				// backgroundMusic.Dispose(); 
				player = null;
			};

			//Background Music play
			player.Play();
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
