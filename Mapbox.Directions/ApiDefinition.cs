using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreLocation;

namespace Mapbox.Directions
{
    // @interface MBDirections : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBDirections
    {
        // @property (readonly, nonatomic, strong, class) MBDirections * _Nonnull sharedDirections;
        [Static]
        [Export("sharedDirections", ArgumentSemantic.Strong)]
        MBDirections SharedDirections { get; }

        // -(instancetype _Nonnull)initWithAccessToken:(NSString * _Nullable)accessToken host:(NSString * _Nullable)host __attribute__((objc_designated_initializer));
        [Export("initWithAccessToken:host:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string accessToken, [NullAllowed] string host);

        // -(instancetype _Nonnull)initWithAccessToken:(NSString * _Nullable)accessToken;
        [Export("initWithAccessToken:")]
        IntPtr Constructor([NullAllowed] string accessToken);

        // -(NSURLSessionDataTask * _Nonnull)calculateDirectionsWithOptions:(MBRouteOptions * _Nonnull)options completionHandler:(void (^ _Nonnull)(NSArray<MBWaypoint *> * _Nullable, NSArray<MBRoute *> * _Nullable, NSError * _Nullable))completionHandler __attribute__((warn_unused_result));
        [Export("calculateDirectionsWithOptions:completionHandler:")]
        NSUrlSessionDataTask CalculateDirectionsWithOptions(MBRouteOptions options, Action<NSArray<MBWaypoint>, NSArray<MBRoute>, NSError> completionHandler);

        // -(NSURL * _Nonnull)URLForCalculatingDirectionsWithOptions:(MBRouteOptions * _Nonnull)options __attribute__((warn_unused_result));
        [Export("URLForCalculatingDirectionsWithOptions:")]
        NSUrl URLForCalculatingDirectionsWithOptions(MBRouteOptions options);
    }

    // @interface MBIntersection : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBIntersection : INSSecureCoding
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D location;
        [Export("location")]
        CLLocationCoordinate2D Location { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull headings;
        [Export("headings", ArgumentSemantic.Copy)]
        NSNumber[] Headings { get; }

        // @property (readonly, copy, nonatomic) NSIndexSet * _Nonnull outletIndexes;
        [Export("outletIndexes", ArgumentSemantic.Copy)]
        NSIndexSet OutletIndexes { get; }

        // @property (readonly, nonatomic) NSInteger approachIndex;
        [Export("approachIndex")]
        nint ApproachIndex { get; }

        // @property (readonly, nonatomic) NSInteger outletIndex;
        [Export("outletIndex")]
        nint OutletIndex { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBLane *> * _Nullable approachLanes;
        [NullAllowed, Export("approachLanes", ArgumentSemantic.Copy)]
        MBLane[] ApproachLanes { get; }

        // @property (readonly, copy, nonatomic) NSIndexSet * _Nullable usableApproachLanes;
        [NullAllowed, Export("usableApproachLanes", ArgumentSemantic.Copy)]
        NSIndexSet UsableApproachLanes { get; }


        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    // @interface MBLane : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBLane : INSSecureCoding
    {
        // @property (readonly, nonatomic) MBLaneIndication indications;
        [Export("indications")]
        MBLaneIndication Indications { get; }


        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    // @interface MBRoute : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRoute : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json waypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints routeOptions:(MBRouteOptions * _Nonnull)routeOptions;
        [Export("initWithJson:waypoints:routeOptions:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json, MBWaypoint[] waypoints, MBRouteOptions routeOptions);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }


        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nullable coordinates;
        [NullAllowed, Export("coordinates", ArgumentSemantic.Copy)]
        NSValue[] Coordinates { get; }

        // @property (readonly, nonatomic) NSUInteger coordinateCount;
        [Export("coordinateCount")]
        nuint CoordinateCount { get; }

        // -(void)getCoordinates:(CLLocationCoordinate2D * _Nonnull)coordinates;
        [Export("getCoordinates:")]
        unsafe void GetCoordinates(ref CLLocationCoordinate2D coordinates);

        // @property (readonly, copy, nonatomic) NSArray<MBRouteLeg *> * _Nonnull legs;
        [Export("legs", ArgumentSemantic.Copy)]
        MBRouteLeg[] Legs { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, nonatomic) CLLocationDistance distance;
        [Export("distance")]
        double Distance { get; }

        // @property (readonly, nonatomic) NSTimeInterval expectedTravelTime;
        [Export("expectedTravelTime")]
        double ExpectedTravelTime { get; }

        // @property (readonly, nonatomic, strong) MBRouteOptions * _Nonnull routeOptions;
        [Export("routeOptions", ArgumentSemantic.Strong)]
        MBRouteOptions RouteOptions { get; }

        // @property (copy, nonatomic) NSString * _Nullable accessToken;
        [NullAllowed, Export("accessToken")]
        string AccessToken { get; set; }

        // @property (copy, nonatomic) NSURL * _Nullable apiEndpoint;
        [NullAllowed, Export("apiEndpoint", ArgumentSemantic.Copy)]
        NSUrl ApiEndpoint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable routeIdentifier;
        [NullAllowed, Export("routeIdentifier")]
        string RouteIdentifier { get; set; }
    }

    // @interface MBRouteLeg : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteLeg : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json source:(MBWaypoint * _Nonnull)source destination:(MBWaypoint * _Nonnull)destination profileIdentifier:(MBDirectionsProfileIdentifier _Nonnull)profileIdentifier;
        [Export("initWithJson:source:destination:profileIdentifier:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json, MBWaypoint source, MBWaypoint destination, string profileIdentifier);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }


        // @property (readonly, nonatomic, strong) MBWaypoint * _Nonnull source;
        [Export("source", ArgumentSemantic.Strong)]
        MBWaypoint Source { get; }

        // @property (readonly, nonatomic, strong) MBWaypoint * _Nonnull destination;
        [Export("destination", ArgumentSemantic.Strong)]
        MBWaypoint Destination { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBRouteStep *> * _Nonnull steps;
        [Export("steps", ArgumentSemantic.Copy)]
        MBRouteStep[] Steps { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable openStreetMapNodeIdentifiers;
        [NullAllowed, Export("openStreetMapNodeIdentifiers", ArgumentSemantic.Copy)]
        NSNumber[] OpenStreetMapNodeIdentifiers { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable segmentDistances;
        [NullAllowed, Export("segmentDistances", ArgumentSemantic.Copy)]
        NSNumber[] SegmentDistances { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable expectedSegmentTravelTimes;
        [NullAllowed, Export("expectedSegmentTravelTimes", ArgumentSemantic.Copy)]
        NSNumber[] ExpectedSegmentTravelTimes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nullable segmentSpeeds;
        [NullAllowed, Export("segmentSpeeds", ArgumentSemantic.Copy)]
        NSNumber[] SegmentSpeeds { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, nonatomic) CLLocationDistance distance;
        [Export("distance")]
        double Distance { get; }

        // @property (readonly, nonatomic) NSTimeInterval expectedTravelTime;
        [Export("expectedTravelTime")]
        double ExpectedTravelTime { get; }

        // @property (readonly, nonatomic) MBDirectionsProfileIdentifier _Nonnull profileIdentifier;
        [Export("profileIdentifier")]
        string ProfileIdentifier { get; }
    }

    // @interface MBRouteOptions : NSObject <NSCopying, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteOptions : INSCopying, INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(MBDirectionsProfileIdentifier _Nullable)profileIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithWaypoints:profileIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBWaypoint[] waypoints, [NullAllowed] string profileIdentifier);

        // -(instancetype _Nonnull)initWithLocations:(NSArray<CLLocation *> * _Nonnull)locations profileIdentifier:(MBDirectionsProfileIdentifier _Nullable)profileIdentifier;
        [Export("initWithLocations:profileIdentifier:")]
        IntPtr Constructor(CLLocation[] locations, [NullAllowed] string profileIdentifier);

        // -(instancetype _Nonnull)initWithCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates profileIdentifier:(MBDirectionsProfileIdentifier _Nullable)profileIdentifier;
        [Export("initWithCoordinates:profileIdentifier:")]
        IntPtr Constructor(NSValue[] coordinates, [NullAllowed] string profileIdentifier);


        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

        // @property (copy, nonatomic) NSArray<MBWaypoint *> * _Nonnull waypoints;
        [Export("waypoints", ArgumentSemantic.Copy)]
        MBWaypoint[] Waypoints { get; set; }

        // @property (nonatomic) BOOL allowsUTurnAtWaypoint;
        [Export("allowsUTurnAtWaypoint")]
        bool AllowsUTurnAtWaypoint { get; set; }

        // @property (nonatomic) MBDirectionsProfileIdentifier _Nonnull profileIdentifier;
        [Export("profileIdentifier")]
        string ProfileIdentifier { get; set; }

        // @property (nonatomic) BOOL includesAlternativeRoutes;
        [Export("includesAlternativeRoutes")]
        bool IncludesAlternativeRoutes { get; set; }

        // @property (nonatomic) BOOL includesSteps;
        [Export("includesSteps")]
        bool IncludesSteps { get; set; }

        // @property (nonatomic) enum MBRouteShapeFormat shapeFormat;
        [Export("shapeFormat", ArgumentSemantic.Assign)]
        MBRouteShapeFormat ShapeFormat { get; set; }

        // @property (nonatomic) enum MBRouteShapeResolution routeShapeResolution;
        [Export("routeShapeResolution", ArgumentSemantic.Assign)]
        MBRouteShapeResolution RouteShapeResolution { get; set; }

        // @property (nonatomic) MBAttributeOptions attributeOptions;
        [Export("attributeOptions", ArgumentSemantic.Assign)]
        MBAttributeOptions AttributeOptions { get; set; }

        // @property (nonatomic) BOOL includesExitRoundaboutManeuver;
        [Export("includesExitRoundaboutManeuver")]
        bool IncludesExitRoundaboutManeuver { get; set; }

        // @property (copy, nonatomic) NSLocale * _Nonnull locale;
        [Export("locale", ArgumentSemantic.Copy)]
        NSLocale Locale { get; set; }

        // @property (nonatomic) BOOL includesSpokenInstructions;
        [Export("includesSpokenInstructions")]
        bool IncludesSpokenInstructions { get; set; }

        // @property (nonatomic) enum MBMeasurementSystem distanceMeasurementSystem;
        [Export("distanceMeasurementSystem", ArgumentSemantic.Assign)]
        MBMeasurementSystem DistanceMeasurementSystem { get; set; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // -(BOOL)isEqualToRouteOptions:(MBRouteOptions * _Nullable)routeOptions __attribute__((warn_unused_result));
        [Export("isEqualToRouteOptions:")]
        bool IsEqualToRouteOptions([NullAllowed] MBRouteOptions routeOptions);
    }

    // @interface MBRouteOptionsV4 : MBRouteOptions
    [BaseType(typeof(MBRouteOptions))]
    interface MBRouteOptionsV4
    {
        // @property (nonatomic) enum MBInstructionFormat instructionFormat;
        [Export("instructionFormat", ArgumentSemantic.Assign)]
        MBInstructionFormat InstructionFormat { get; set; }

        // @property (nonatomic) BOOL includesShapes;
        [Export("includesShapes")]
        bool IncludesShapes { get; set; }

        //// -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(MBDirectionsProfileIdentifier _Nullable)profileIdentifier __attribute__((objc_designated_initializer));
        //[Export("initWithWaypoints:profileIdentifier:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(MBWaypoint[] waypoints, [NullAllowed] string profileIdentifier);

    }

    // @interface MBRouteStep : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteStep : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json;
        [Export("initWithJson:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nullable coordinates;
        [NullAllowed, Export("coordinates", ArgumentSemantic.Copy)]
        NSValue[] Coordinates { get; }

        // @property (readonly, nonatomic) NSUInteger coordinateCount;
        [Export("coordinateCount")]
        nuint CoordinateCount { get; }

        // -(BOOL)getCoordinates:(CLLocationCoordinate2D * _Nonnull)coordinates __attribute__((warn_unused_result));
        [Export("getCoordinates:")]
        unsafe bool GetCoordinates(ref CLLocationCoordinate2D coordinates);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull instructions;
        [Export("instructions")]
        string Instructions { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBSpokenInstruction *> * _Nullable instructionsSpokenAlongStep;
        [NullAllowed, Export("instructionsSpokenAlongStep", ArgumentSemantic.Copy)]
        MBSpokenInstruction[] InstructionsSpokenAlongStep { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, nonatomic) CLLocationCoordinate2D maneuverLocation;
        [Export("maneuverLocation")]
        CLLocationCoordinate2D ManeuverLocation { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable exitCodes;
        [NullAllowed, Export("exitCodes", ArgumentSemantic.Copy)]
        string[] ExitCodes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable exitNames;
        [NullAllowed, Export("exitNames", ArgumentSemantic.Copy)]
        string[] ExitNames { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable phoneticExitNames;
        [NullAllowed, Export("phoneticExitNames", ArgumentSemantic.Copy)]
        string[] PhoneticExitNames { get; }

        // @property (readonly, nonatomic) CLLocationDistance distance;
        [Export("distance")]
        double Distance { get; }

        // @property (readonly, nonatomic) NSTimeInterval expectedTravelTime;
        [Export("expectedTravelTime")]
        double ExpectedTravelTime { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable names;
        [NullAllowed, Export("names", ArgumentSemantic.Copy)]
        string[] Names { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable phoneticNames;
        [NullAllowed, Export("phoneticNames", ArgumentSemantic.Copy)]
        string[] PhoneticNames { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable codes;
        [NullAllowed, Export("codes", ArgumentSemantic.Copy)]
        string[] Codes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable destinationCodes;
        [NullAllowed, Export("destinationCodes", ArgumentSemantic.Copy)]
        string[] DestinationCodes { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable destinations;
        [NullAllowed, Export("destinations", ArgumentSemantic.Copy)]
        string[] Destinations { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBIntersection *> * _Nullable intersections;
        [NullAllowed, Export("intersections", ArgumentSemantic.Copy)]
        MBIntersection[] Intersections { get; }
    }

    // @interface MBSpokenInstruction : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBSpokenInstruction : INSSecureCoding
    {
        // @property (readonly, nonatomic) CLLocationDistance distanceAlongStep;
        [Export("distanceAlongStep")]
        double DistanceAlongStep { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull text;
        [Export("text")]
        string Text { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull ssmlText;
        [Export("ssmlText")]
        string SsmlText { get; }

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    // @interface MBWaypoint : NSObject <NSCopying, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    //[DisableDefaultCtor]
    interface MBWaypoint : INSCopying, INSSecureCoding
    {
        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

        // -(instancetype _Nonnull)initWithCoordinate:(CLLocationCoordinate2D)coordinate coordinateAccuracy:(CLLocationAccuracy)coordinateAccuracy name:(NSString * _Nullable)name __attribute__((objc_designated_initializer));
        [Export("initWithCoordinate:coordinateAccuracy:name:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocationCoordinate2D coordinate, double coordinateAccuracy, [NullAllowed] string name);

        // -(instancetype _Nonnull)initWithLocation:(CLLocation * _Nonnull)location heading:(CLHeading * _Nullable)heading name:(NSString * _Nullable)name __attribute__((objc_designated_initializer));
        [Export("initWithLocation:heading:name:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocation location, [NullAllowed] CLHeading heading, [NullAllowed] string name);

    
        // @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        // @property (nonatomic) CLLocationAccuracy coordinateAccuracy;
        [Export("coordinateAccuracy")]
        double CoordinateAccuracy { get; set; }

        // @property (nonatomic) CLLocationDirection heading;
        [Export("heading")]
        double Heading { get; set; }

        // @property (nonatomic) CLLocationDirection headingAccuracy;
        [Export("headingAccuracy")]
        double HeadingAccuracy { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        //// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        //[Export("description")]
        //string Description { get; }
    }

    [Static]
    partial interface MBDirectionsProfileIdentifier
    {
        // extern const MBDirectionsProfileIdentifier MBDirectionsProfileIdentifierAutomobile;
        [Field("MBDirectionsProfileIdentifierAutomobile", "__Internal")]
        NSString Automobile { get; }

        // extern const MBDirectionsProfileIdentifier MBDirectionsProfileIdentifierAutomobileAvoidingTraffic;
        [Field("MBDirectionsProfileIdentifierAutomobileAvoidingTraffic", "__Internal")]
        NSString AutomobileAvoidingTraffic { get; }

        // extern const MBDirectionsProfileIdentifier MBDirectionsProfileIdentifierCycling;
        [Field("MBDirectionsProfileIdentifierCycling", "__Internal")]
        NSString Cycling { get; }

        // extern const MBDirectionsProfileIdentifier MBDirectionsProfileIdentifierWalking;
        [Field("MBDirectionsProfileIdentifierWalking", "__Internal")]
        NSString Walking { get; }
    }
}
