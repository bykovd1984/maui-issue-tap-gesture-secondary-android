using Android.App;
using Android.Runtime;

namespace maui_issue_tap_gesture_secondary_android
{
  [Application]
  public class MainApplication : MauiApplication
  {
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
      : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
  }
}