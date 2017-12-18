using System;

namespace Mapbox.Directions
{

    
public enum MBAttributeOptions : ulong
{
    OpenStreetMapNodeIdentifier = (1 << 1),
    Distance = (1 << 2),
    ExpectedTravelTime = (1 << 3),
    Speed = (1 << 4),
    CongestionLevel = (1 << 5)
}


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


public enum MBRoadClasses : ulong
{
    Toll = (1 << 1),
    Restricted = (1 << 2),
    Motorway = (1 << 3),
    Ferry = (1 << 4)
}


public enum MBCongestionLevel : long
{
    Unknown = 0,
    Low = 1,
    Moderate = 2,
    Heavy = 3,
    Severe = 4
}


public enum MBInstructionFormat : ulong
{
    Text = 0,
    Html = 1
}


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


public enum MBMeasurementSystem : ulong
{
    Imperial = 0,
    Metric = 1
}


public enum MBRouteShapeFormat : ulong
{
    GeoJSON = 0,
    Polyline = 1,
    Polyline6 = 2
}


public enum MBRouteShapeResolution : ulong
{
    None = 0,
    Low = 1,
    Full = 2
}


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
