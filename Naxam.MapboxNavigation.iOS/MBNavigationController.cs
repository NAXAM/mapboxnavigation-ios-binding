using System;

namespace Naxam.MapboxNavigation.iOS
{
    public partial class MBNavigationController
    {
        static MBNavigationController()
        {
            var x = new MapboxMobileEvents.MMEAPIClient();
            var t = new AWSCore.AWSCancellationToken();
            var l = new AWSPolly.AWSPollyResources();
            var w = new Ricardo.SDWebImage.iOS.SDWebImageFrame();
        }
    }
}
