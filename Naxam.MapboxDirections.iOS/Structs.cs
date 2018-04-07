
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
        /// <summary>
        /// The step does not have a particular maneuver direction associated with it.
        /// This maneuver direction is used as a workaround for bridging to Objective-C which does not support nullable enumeration-typed values.
        /// </summary>
        None = 0,
        /// <summary>
        /// The maneuver requires a sharp turn to the right.
        /// </summary>
        SharpRight = 1,
        /// <summary>
        /// The maneuver requires a turn to the right, a merge to the right, or an exit on the right, or the destination is on the right.
        /// </summary>
        Right = 2,
        /// <summary>
        /// The maneuver requires a slight turn to the right.
        /// </summary>
        SlightRight = 3,
        /// <summary>
        /// The maneuver requires no notable change in direction, or the destination is straight ahead.
        /// </summary>
        StraightAhead = 4,
        /// <summary>
        /// The maneuver requires a slight turn to the left.
        /// </summary>
        SlightLeft = 5,
        /// <summary>
        /// The maneuver requires a turn to the left, a merge to the left, or an exit on the left, or the destination is on the right.
        /// </summary>
        Left = 6,
        /// <summary>
        /// The maneuver requires a sharp turn to the left.
        /// </summary>
        SharpLeft = 7,
        /// <summary>
        /// The maneuver requires a U-turn when possible.
        /// Use the difference between the step’s initial and final headings to distinguish between a U-turn to the left (typical in countries that drive on the right) and a U-turn on the right (typical in countries that drive on the left). If the difference in headings is greater than 180 degrees, the maneuver requires a U-turn to the left. If the difference in headings is less than 180 degrees, the maneuver requires a U-turn to the right.
        /// </summary>
        UTurn = 8,
    }

    [Native]
    public enum MBManeuverType : long
    {
        /// <summary>
        /// The step does not have a particular maneuver type associated with it.
        /// This maneuver type is used as a workaround for bridging to Objective-C which does not support nullable enumeration-typed values.
        /// </summary>
          None = 0,
        /// <summary>
        /// The step requires the user to depart from a waypoint.
        /// If the waypoint is some distance away from the nearest road, the maneuver direction indicates the direction the user must turn upon reaching the road.
        /// </summary>
          Depart = 1,
        /// <summary>
        /// The step requires the user to turn.
        /// The maneuver direction indicates the direction in which the user must turn relative to the current direction of travel. The exit index indicates the number of intersections, large or small, from the previous maneuver up to and including the intersection at which the user must turn.
        /// </summary>
          Turn = 2,
        /// <summary>
        /// The step requires the user to continue after a turn.
        /// </summary>
          Continue = 3,
        /// <summary>
        /// The step requires the user to continue on the current road as it changes names.
        /// The step’s name contains the road’s new name. To get the road’s old name, use the previous step’s name.
        /// </summary>
          PassNameChange = 4,
        /// <summary>
        /// The step requires the user to merge onto another road.
        /// The maneuver direction indicates the side from which the other road approaches the intersection relative to the user.
        /// </summary>
          Merge = 5,
        /// <summary>
        /// The step requires the user to take a entrance ramp (slip road) onto a highway.
        /// </summary>
          TakeOnRamp = 6,
        /// <summary>
        /// The step requires the user to take an exit ramp (slip road) off a highway.
        /// The maneuver direction indicates the side of the highway from which the user must exit. The exit index indicates the number of highway exits from the previous maneuver up to and including the exit that the user must take.
        /// </summary>
          TakeOffRamp = 7,
        /// <summary>
        /// The step requires the user to choose a fork at a Y-shaped fork in the road.
        /// The maneuver direction indicates which fork to take.
        /// </summary>
          ReachFork = 8,
        /// <summary>
        /// The step requires the user to turn at either a T-shaped three-way intersection or a sharp bend in the road where the road also changes names.
        /// This maneuver type is called out separately so that the user may be able to proceed more confidently, without fear of having overshot the turn. If this distinction is unimportant to you, you may treat the maneuver as an ordinary <code>turn</code>.
        /// </summary>
          ReachEnd = 9,
        /// <summary>
        /// The step requires the user to get into a specific lane in order to continue along the current road.
        /// The maneuver direction is set to <code>straightAhead</code>. Each of the first intersection’s usable approach lanes also has an indication of <code>straightAhead</code>. A maneuver in a different direction would instead have a maneuver type of <code>turn</code>.
        /// This maneuver type is called out separately so that the application can present the user with lane guidance based on the first element in the <code>intersections</code> property. If lane guidance is unimportant to you, you may treat the maneuver as an ordinary <code>continue</code> or ignore it.
        /// </summary>
          UseLane = 10,
        /// <summary>
        /// The step requires the user to enter and traverse a roundabout (traffic circle or rotary).
        /// The step has no name, but the exit name is the name of the road to take to exit the roundabout. The exit index indicates the number of roundabout exits up to and including the exit to take.
        /// If <code>RouteOptions.includesExitRoundaboutManeuver</code> is set to <code>true</code>, this step is followed by an <code>.exitRoundabout</code> maneuver. Otherwise, this step represents the entire roundabout maneuver, from the entrance to the exit.
        /// </summary>
          TakeRoundabout = 11,
        /// <summary>
        /// The step requires the user to enter and traverse a large, named roundabout (traffic circle or rotary).
        /// The step’s name is the name of the roundabout. The exit name is the name of the road to take to exit the roundabout. The exit index indicates the number of rotary exits up to and including the exit that the user must take.
        /// If <code>RouteOptions.includesExitRoundaboutManeuver</code> is set to <code>true</code>, this step is followed by an <code>.exitRotary</code> maneuver. Otherwise, this step represents the entire roundabout maneuver, from the entrance to the exit.
        /// </summary>
          TakeRotary = 12,
        /// <summary>
        /// The step requires the user to enter and exit a roundabout (traffic circle or rotary) that is compact enough to constitute a single intersection.
        /// The step’s name is the name of the road to take after exiting the roundabout. This maneuver type is called out separately because the user may perceive the roundabout as an ordinary intersection with an island in the middle. If this distinction is unimportant to you, you may treat the maneuver as either an ordinary <code>turn</code> or as a <code>takeRoundabout</code>.
        /// </summary>
          TurnAtRoundabout = 13,
        /// <summary>
        /// The step requires the user to exit a roundabout (traffic circle or rotary).
        /// This maneuver type follows a <code>.takeRoundabout</code> maneuver. It is only used when <code>RouteOptions.includesExitRoundaboutManeuver</code> is set to true.
        /// </summary>
          ExitRoundabout = 14,
        /// <summary>
        /// The step requires the user to exit a large, named roundabout (traffic circle or rotary).
        /// This maneuver type follows a <code>.takeRotary</code> maneuver. It is only used when <code>RouteOptions.includesExitRoundaboutManeuver</code> is set to true.
        /// </summary>
          ExitRotary = 15,
        /// <summary>
        /// The step requires the user to respond to a change in travel conditions.
        /// This maneuver type may occur for example when driving directions require the user to board a ferry, or when cycling directions require the user to dismount. The step’s transport type and instructions contains important contextual details that should be presented to the user at the maneuver location.
        /// Similar changes can occur simultaneously with other maneuvers, such as when the road changes its name at the site of a movable bridge. In such cases, <code>heedWarning</code> is suppressed in favor of another maneuver type.
        /// </summary>
          HeedWarning = 16,
        /// <summary>
        /// The step requires the user to arrive at a waypoint.
        /// The distance and expected travel time for this step are set to zero, indicating that the route or route leg is complete. The maneuver direction indicates the side of the road on which the waypoint can be found (or whether it is straight ahead).
        /// </summary>
          Arrive = 17,
        /// <summary>
        /// The step requires the user to arrive at an intermediate waypoint.
        /// This maneuver type is only used by version 4 of the Mapbox Directions API.
        /// </summary>
        PassWaypoint = 18,
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
        /// The step does not have a particular transport type associated with it.
        /// This transport type is used as a workaround for bridging to Objective-C which does not support nullable enumeration-typed values.
          None = 0,
        /// The route requires the user to drive or ride a car, truck, or motorcycle.
        /// This is the usual transport type when the <code>profileIdentifier</code> is <code>MBDirectionsProfileIdentifierAutomobile</code> or <code>MBDirectionsProfileIdentifierAutomobileAvoidingTraffic</code>.
          Automobile = 1,
        /// The route requires the user to board a ferry.
        /// The user should verify that the ferry is in operation. For driving and cycling directions, the user should also verify that his or her vehicle is permitted onboard the ferry.
          Ferry = 2,
        /// The route requires the user to cross a movable bridge.
        /// The user may need to wait for the movable bridge to become passable before continuing.
          MovableBridge = 3,
        /// The route becomes impassable at this point.
        /// You should not encounter this transport type under normal circumstances.
          Inaccessible = 4,
        /// The route requires the user to walk.
        /// This is the usual transport type when the <code>profileIdentifier</code> is <code>MBDirectionsProfileIdentifierWalking</code>. For cycling directions, this value indicates that the user is expected to dismount.
          Walking = 5,
        /// The route requires the user to ride a bicycle.
        /// This is the usual transport type when the <code>profileIdentifier</code> is <code>MBDirectionsProfileIdentifierCycling</code>.
          Cycling = 6,
        /// The route requires the user to board a train.
        /// The user should consult the train’s timetable. For cycling directions, the user should also verify that bicycles are permitted onboard the train.
          Train = 7,
    }

    /// <code>VisualInstructionComponentType</code> describes the type of <code>VisualInstructionComponent</code>.
    //typedef SWIFT_ENUM_NAMED(NSInteger, MBVisualInstructionComponentType, "VisualInstructionComponentType") {
    [Native]
    public enum MBVisualInstructionComponentType : long
    {
        /// The component separates two other destination components.
        /// If the two adjacent components are both displayed as images, you can hide this delimiter component.
          Delimiter = 0,
        /// The component bears an exit number or the name of a place or street.
          Text = 1,
        /// Component contains an image that should be rendered.
          Image = 2,
    }
}
