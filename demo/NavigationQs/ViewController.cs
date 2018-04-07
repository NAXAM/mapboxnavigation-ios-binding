using System;

using UIKit;
using MapboxDirections;
using CoreLocation;
using Mapbox;
using MapboxNavigation;
using MapboxCoreNavigation;
using MapboxMobileEvents;
using Ricardo.SDWebImage.iOS;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;

namespace NavigationQs
{
    public partial class ViewController : UIViewController, IMGLMapViewDelegate
    {
        MGLMapView mapView;
        CLLocationCoordinate2D? destinationCoordinate;
        CLLocationCoordinate2D? userCoordinate;
        UIBarButtonItem routingItem;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            mapView = new MGLMapView()
            {
                UserTrackingMode = MGLUserTrackingMode.Follow,
                WeakDelegate = this
            };
            View.AddSubview(mapView);

            var bottomToolbar = new UIToolbar()
            {
                Tag = 101
            };
            View.AddSubview(bottomToolbar);
            var items = new List<UIBarButtonItem>();

            var bottomMessageLbl = new UILabel()
            {
                Text = "Long press to\nselect destination",
                Lines = 2
            };
            bottomMessageLbl.SizeToFit();
            var messageItem = new UIBarButtonItem()
            {
                CustomView = bottomMessageLbl
            };
            items.Add(messageItem);
            items.Add(new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace));
            routingItem = new UIBarButtonItem("Show navigation", UIBarButtonItemStyle.Plain, DidTapOnRoutingBtn)
            {
                Enabled = false
            };
            items.Add(routingItem);

            bottomToolbar.SetItems(items.ToArray(), false);

            var longPress = new UILongPressGestureRecognizer(DidLongPressOnMap);
            mapView.AddGestureRecognizer(longPress);
        }

        private void DidLongPressOnMap(UILongPressGestureRecognizer sender)
        {
            if (sender.State != UIGestureRecognizerState.Began)
            {
                return;
            }

            var point = sender.LocationInView(mapView);
            destinationCoordinate = mapView.ConvertPoint(point, mapView);
            if (mapView.Annotations != null) {
                mapView.RemoveAnnotations(mapView.Annotations);
            }
            mapView.AddAnnotation(new MGLPointAnnotation()
            {
                Coordinate = (CoreLocation.CLLocationCoordinate2D)destinationCoordinate
            });
            routingItem.Enabled = userCoordinate != null && destinationCoordinate != null;
        }

        private void DidTapOnRoutingBtn(object sender, EventArgs e)
        {
            var origin = new MBWaypoint((CoreLocation.CLLocationCoordinate2D)userCoordinate,
            -1,
            "Your location");

            var destination = new MBWaypoint((CoreLocation.CLLocationCoordinate2D)destinationCoordinate,
                                        -1,
                                             "Destination");
            var options = new MBNavigationRouteOptions(
                new MBWaypoint[] { origin, destination },
                MBDirectionsProfileIdentifier.AutomobileAvoidingTraffic
            );

            MBDirections.SharedDirections.CalculateDirectionsWithOptions(
            options,
            (waypoints, routes, error) =>
            {
                if (routes == null || routes.Length == 0)
                {
                    string errorMessage = "No routes found";
                    if (error != null)
                    {
                        errorMessage = error.LocalizedDescription;
                    }
                    var alert = UIAlertController.Create("Error", errorMessage, UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("Dismiss", UIAlertActionStyle.Cancel, null));
                    PresentViewController(alert, true, null);
                }
                else
                {
                    var locationManager = new MBSimulatedLocationManager(routes[0]);

                    var viewController = new MBNavigationViewController(routes[0], MBDirections.SharedDirections, null, locationManager);
                    PresentViewController(viewController, true, null);
                }
            });
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            var size = View.Bounds.Size;
            mapView.Frame = new CGRect(0, 0, size.Width, size.Height - 44);
            View.ViewWithTag(101).Frame = new CGRect(0, mapView.Frame.GetMaxY(), size.Width, 44);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region MGLMapViewDelegate
    

        [Export("mapView:didUpdateUserLocation:")]
        public void MapViewDidUpdateUserLocation(MGLMapView mapView, MGLUserLocation userLocation)
        {
            userCoordinate = userLocation.Coordinate;
            routingItem.Enabled = userCoordinate != null && destinationCoordinate != null;
        }
        #endregion
    }
}
