﻿using ObjCRuntime;
using UIKit;

namespace maui_issue_tap_gesture_secondary_android
{
  public class Program
  {
    // This is the main entry point of the application.
    static void Main(string[] args)
    {
      // if you want to use a different Application Delegate class from "AppDelegate"
      // you can specify it here.
      UIApplication.Main(args, null, typeof(AppDelegate));
    }
  }
}