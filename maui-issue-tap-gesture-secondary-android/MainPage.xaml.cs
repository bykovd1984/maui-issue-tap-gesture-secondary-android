namespace maui_issue_tap_gesture_secondary_android
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      Strings = Enumerable.Range(1, 100).Select(i => i.ToString()).ToArray();

      BindingContext = this;
    }

    public string[] Strings { get; }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
  }
}