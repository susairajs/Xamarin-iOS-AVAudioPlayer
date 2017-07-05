// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSAVAudioPlayer
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPlay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnStop { get; set; }

        [Action ("BtnPlay_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnPlay_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnStop_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnStop_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnPlay != null) {
                btnPlay.Dispose ();
                btnPlay = null;
            }

            if (btnStop != null) {
                btnStop.Dispose ();
                btnStop = null;
            }
        }
    }
}