using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapboxNavigation
{
    [Native]
    public enum ManeuversStyleKitResizingBehavior : long
    {
        AspectFit = 0,
        AspectFill = 1,
        Stretch = 2,
        Center = 3
    }

    [Native]
    public enum MBStyleType : long
    {
        DayStyle = 0,
        NightStyle = 1
    }
}
