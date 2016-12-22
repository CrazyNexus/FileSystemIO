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

namespace FileIO
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton fileButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton logButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton readButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton writeButton { get; set; }

        [Action ("FileButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FileButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LogButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LogButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ReadButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ReadButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("WriteButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void WriteButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (fileButton != null) {
                fileButton.Dispose ();
                fileButton = null;
            }

            if (logButton != null) {
                logButton.Dispose ();
                logButton = null;
            }

            if (readButton != null) {
                readButton.Dispose ();
                readButton = null;
            }

            if (writeButton != null) {
                writeButton.Dispose ();
                writeButton = null;
            }
        }
    }
}