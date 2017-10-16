using System;
using Xamarin.Forms;
using Plugin.Geolocator;
using System.Diagnostics;
using Xamarin.Forms.Maps;

namespace MapR
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      var maplocator = CrossGeolocator.Current;
      maplocator.DesiredAccuracy = 500;
      var geoCoder = new Geocoder(); Device.BeginInvokeOnMainThread(async () =>
      {
        try
        {
          if (!maplocator.IsListening)
          {
            await maplocator.StartListeningAsync(TimeSpan.FromMinutes(1), 50, true);
          }

                //GeoMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(currentpos.Latitude, currentpos.Longitude), Distance.FromMiles(1)));
              }
        catch (Exception ex)
        {
          Debug.WriteLine("Fail" + ex);
        }
      });
      maplocator.PositionChanged += (sender, e) =>
    {
      var position = e.Position;
      Model.Location.Latitude = position.Latitude;
      Model.Location.Longitude = position.Longitude;
    };

      MainPage = new Views.ListBranch();
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}
