﻿using Xamarin.Forms;
using MapR.Controls;
using MapR.Droid.Renderers;
using Android.Gms.Maps.Model;
using Xamarin.Forms.Maps.Android;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace MapR.Droid.Renderers
{
  /// <summary>
  /// Render para los mapas personalizados
  /// </summary>
  public class CustomMapRenderer : MapRenderer
  {
    CustomCircle circle;
    bool isDrawn;

    protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.Maps.Map> e)
    {
      base.OnElementChanged(e);

      if (e.OldElement != null)
      {
      }

      if (e.NewElement != null)
      {
        var formsMap = (CustomMap)e.NewElement;
        circle = formsMap.Circle;
        Control.GetMapAsync(this);
      }
    }

    protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);

      if (e.PropertyName.Equals("VisibleRegion") && !isDrawn)
      {
        var circleOptions = new CircleOptions();
        circleOptions.InvokeCenter(new LatLng(circle.Position.Latitude, circle.Position.Longitude));
        circleOptions.InvokeRadius(circle.Radius);
        circleOptions.InvokeFillColor(0x66ffff00);
        circleOptions.InvokeStrokeColor(0x66ffff00);
        circleOptions.InvokeStrokeWidth(0);

        NativeMap.AddCircle(circleOptions);
        isDrawn = true;
      }
    }
  }
}
