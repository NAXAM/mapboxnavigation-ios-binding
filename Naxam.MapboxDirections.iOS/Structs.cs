
using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapboxDirections
{

    [Native]
    public enum MBAttributeOptions : ulong
    {
        OpenStreetMapNodeIdentifier = (1 << 1),
        Distance = (1 << 2),
        ExpectedTravelTime = (1 << 3),
        Speed = (1 << 4),
        CongestionLevel = (1 << 5)
    }

    [Native]
    public enum MBLaneIndication : ulong
    {
        SharpRight = (1 << 1),
        Right = (1 << 2),
        SlightRight = (1 << 3),
        StraightAhead = (1 << 4),
        SlightLeft = (1 << 5),
        Left = (1 << 6),
        SharpLeft = (1 << 7),
        UTurn = (1 << 8)
    }

    [Native]
    public enum MBRoadClasses : ulong
    {
        /// <summary>
        /// The road segment is [tolled](https://wiki.openstreetmap.org/wiki/Key:toll).
        /// </summary>
        Toll = (1 << 1),
        
        /// <summary>
        /// The road segment has access restrictions.
        /// A road segment may have this class if there are [general access restrictions](https://wiki.openstreetmap.org/wiki/Key:access) or a [high-occupancy vehicle](https://wiki.openstreetmap.org/wiki/Key:hov) restriction.
        /// </summary>
        Restricted = (1 << 2),
        
        /// <summary>
        /// The road segment is a [freeway](https://wiki.openstreetmap.org/wiki/Tag:highway%3Dmotorway) or [freeway ramp](https://wiki.openstreetmap.org/wiki/Tag:highway%3Dmotorway_link).
        /// It may be desirable to suppress the name of the freeway when giving instructions and give instructions at fixed distances before an exit (such as 1 mile or 1 kilometer ahead).
         /// </summary>
        Motorway = (1 << 3),
        
        /// <summary>
        /// The user must travel this segment of the route by ferry.
        /// The user should verify that the ferry is in operation. For driving and cycling directions, the user should also verify that his or her vehicle is permitted onboard the ferry. 
        /// In general, the transport type of the step containing the road segment is also `TransportType.ferry`.
        /// </summary>
        Ferry = (1 << 4),
        
        /// <summary>
        /// The user must travel this segment of the route through a [tunnel](https://wiki.openstreetmap.org/wiki/Key:tunnel).
        /// </summary>
        Tunnel = (1 << 5),
    }

    [Native]
    public enum MBCongestionLevel : long
    {
        Unknown = 0,
        Low = 1,
        Moderate = 2,
        Heavy = 3,
        Severe = 4
    }

    [Native]
    public enum MBDrivingSide : long
    {
        Left = 0,
        Right = 1
    }

    [Native]
    public enum MBInstructionFormat : ulong
    {
        Text = 0,
        Html = 1
    }

    [Native]
    public enum MBManeuverDirection : long
    {
        SharpRight = 0,
        Right = 1,
        SlightRight = 2,
        StraightAhead = 3,
        SlightLeft = 4,
        Left = 5,
        SharpLeft = 6,
        UTurn = 7
    }

    [Native]
    public enum MBManeuverType : long
    {
        Depart = 0,
        Turn = 1,
        Continue = 2,
        PassNameChange = 3,
        Merge = 4,
        TakeOnRamp = 5,
        TakeOffRamp = 6,
        ReachFork = 7,
        ReachEnd = 8,
        UseLane = 9,
        TakeRoundabout = 10,
        TakeRotary = 11,
        TurnAtRoundabout = 12,
        ExitRoundabout = 13,
        ExitRotary = 14,
        HeedWarning = 15,
        Arrive = 16,
        PassWaypoint = 17
    }

    [Native]
    public enum MBMeasurementSystem : ulong
    {
        Imperial = 0,
        Metric = 1
    }

    [Native]
    public enum MBRouteShapeFormat : ulong
    {
        GeoJSON = 0,
        Polyline = 1,
        Polyline6 = 2
    }

    [Native]
    public enum MBRouteShapeResolution : ulong
    {
        None = 0,
        Low = 1,
        Full = 2
    }

    [Native]
    public enum MBTransportType : long
    {
        Automobile = 0,
        Ferry = 1,
        MovableBridge = 2,
        Inaccessible = 3,
        Walking = 4,
        Cycling = 5,
        Train = 6
    }
}
