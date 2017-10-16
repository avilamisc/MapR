using Xamarin.Forms;
using MapR.ViewModels;
using Xamarin.Forms.Xaml;
using MapR.Model;
using Xamarin.Forms.Maps;
using MapR.Controls;

namespace MapR.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class DetailBranch : ContentPage
  {
    public DetailBranch(BranchModel model)
    {
      InitializeComponent();
      BindingContext = new ListBranchViewModel();
      labelSuc.Text = model.SucName;

      var pin = new Pin
      {
        Type = PinType.Place,
        Position = new Position(Model.Location.Latitude, Model.Location.Longitude),
        Label = "",
        Address = ""
      };

      var position = new Position(Model.Location.Latitude, Model.Location.Longitude);
      //customMap.Circle = new CustomCircle
      //{
      //  Position = position,
      //  Radius = 4000
      //};

      //customMap.Pins.Add(pin);
      //customMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1.0)));
    }
  }
}