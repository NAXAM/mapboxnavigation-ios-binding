using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapboxDirections
{
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

        // -(NSURLSessionDataTask * _Nonnull)calculateDirectionsWithOptions:(MBRouteOptions * _Nonnull)options completionHandler:(void (^ _Nonnull)(NSArray<MBWaypoint *> * _Nullable, NSArray<MBRoute *> * _Nullable, NSError * _Nullable))completionHandler;
        [Export("calculateDirectionsWithOptions:completionHandler:")]
        NSUrlSessionDataTask CalculateDirectionsWithOptions(MBRouteOptions options, Action<MBWaypoint[], MBRoute[], NSError> completionHandler);
        /// Begins asynchronously calculating a match using the given options and delivers the results to a closure.
        /// \param options A <code>MatchOptions</code> object specifying the requirements for the resulting match.
        ///
        /// \param completionHandler The closure (block) to call with the resulting routes. This closure is executed on the application’s main thread.
        ///
        ///
        /// returns:
        /// The data task used to perform the HTTP request. If, while waiting for the completion handler to execute, you no longer want the resulting routes, cancel this task.
        //- (NSURLSessionDataTask* _Nonnull) calculateMatchesWithOptions:(MBMatchOptions* _Nonnull) options completionHandler:(void (^ _Nonnull)(NSArray<MBMatch*>* _Nullable, NSError* _Nullable))completionHandler;
        [Export("calculateMatchesWithOptions:completionHandler:")]
        NSUrlSessionDataTask CalculateMatchesWithOptions(MBMatchOptions options, Action<MBMatch[], NSError> completionHandler);
        //- (NSURLSessionDataTask* _Nonnull) calculateRoutesMatchingOptions:(MBMatchOptions* _Nonnull) options completionHandler:(void (^ _Nonnull)(NSArray<MBWaypoint*>* _Nullable, NSArray<MBRoute*>* _Nullable, NSError* _Nullable))completionHandler;
        [Export("calculateRoutesMatchingOptions:completionHandler:")]
        NSUrlSessionDataTask CalculateRoutesMatchingOptions(MBMatchOptions options, Action<MBWaypoint[], MBRoute[], NSError> completionHandler);

        /// The HTTP URL used to fetch the routes from the API.
        /// After requesting the URL returned by this method, you can parse the JSON data in the response and pass it into the <code>Route.init(json:waypoints:profileIdentifier:)</code> initializer.
        //- (NSURL* _Nonnull) URLForCalculatingDirectionsWithOptions:(MBDirectionsOptions* _Nonnull) options SWIFT_WARN_UNUSED_RESULT;
        [Export("URLForCalculatingDirectionsWithOptions:")]
        NSUrl URLForCalculatingDirectionsWithOptions(MBDirectionsOptions options);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }
    }

    // @interface MBRoute : MBDirectionsResult
    [BaseType(typeof(MBDirectionsResult))]
    [DisableDefaultCtor]
    interface MBRoute
    {
        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json waypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints routeOptions:(MBRouteOptions * _Nonnull)routeOptions;
        [Export("initWithJson:waypoints:routeOptions:"), DesignatedInitializer]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json, MBWaypoint[] waypoints, MBRouteOptions routeOptions);

        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nullable coordinates;
        [NullAllowed, Export("coordinates", ArgumentSemantic.Copy)]
        NSValue[] Coordinates { get; }

        // @property (readonly, nonatomic) NSUInteger coordinateCount;
        [Export("coordinateCount")]
        nuint CoordinateCount { get; }

        // -(void)getCoordinates:(CLLocationCoordinate2D * _Nonnull)coordinates;
        [Export("getCoordinates:")]
        unsafe void GetCoordinates(out CLLocationCoordinate2D coordinates);

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

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

    // @interface MBRouteOptions  : MBDirectionsOptions
    [BaseType(typeof(MBDirectionsOptions))]
    [DisableDefaultCtor]
    interface MBRouteOptions
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

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

        // @property (nonatomic) BOOL includesVisualInstructions;
        [Export("includesVisualInstructions")]
        bool IncludesVisualInstructions { get; set; }

        // @property (nonatomic) MBRoadClasses roadClassesToAvoid;
        [Export("roadClassesToAvoid", ArgumentSemantic.Assign)]
        MBRoadClasses RoadClassesToAvoid { get; set; }

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

        // -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(MBDirectionsProfileIdentifier _Nullable)profileIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithWaypoints:profileIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBWaypoint[] waypoints, [NullAllowed] string profileIdentifier);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);
    }

    // @interface MBRouteStep : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteStep : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json;
        [Export("initWithJson:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

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
        unsafe bool GetCoordinates(out CLLocationCoordinate2D coordinates);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull instructions;
        [Export("instructions")]
        string Instructions { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBSpokenInstruction *> * _Nullable instructionsSpokenAlongStep;
        [NullAllowed, Export("instructionsSpokenAlongStep", ArgumentSemantic.Copy)]
        MBSpokenInstruction[] InstructionsSpokenAlongStep { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBVisualInstruction *> * _Nullable instructionsDisplayedAlongStep;
        [NullAllowed, Export("instructionsDisplayedAlongStep", ArgumentSemantic.Copy)]
        MBVisualInstruction[] InstructionsDisplayedAlongStep { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        /// The type of maneuver required for beginning this step.
        //@property(nonatomic, readonly) enum MBManeuverType maneuverType;
        [Export("maneuverType")]
        MBManeuverType ManeuverType { get; }

        /// Additional directional information to clarify the maneuver type.
        //@property(nonatomic, readonly) enum MBManeuverDirection maneuverDirection;
        [Export("maneuverDirection")]
        MBManeuverDirection ManeuverDirection { get; }

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

        /// The mode of transportation used for the step.
        /// This step may use a different mode of transportation than the overall route.
        //@property(nonatomic, readonly) enum MBTransportType transportType;
        [Export("transportType", ArgumentSemantic.Assign)]
        MBTransportType TransportType { get; }

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

        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json;
        [Export("initWithJson:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json);

        // -(instancetype _Nonnull)initWithDistanceAlongStep:(CLLocationDistance)distanceAlongStep text:(NSString * _Nonnull)text ssmlText:(NSString * _Nonnull)ssmlText __attribute__((objc_designated_initializer));
        [Export("initWithDistanceAlongStep:text:ssmlText:")]
        [DesignatedInitializer]
        IntPtr Constructor(double distanceAlongStep, string text, string ssmlText);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    // @interface MBVisualInstruction : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBVisualInstruction : INSSecureCoding
    {
        // @property (readonly, nonatomic) CLLocationDistance distanceAlongStep;
        [Export("distanceAlongStep")]
        double DistanceAlongStep { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull primaryText;
        [Export("primaryText")]
        string PrimaryText { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBVisualInstructionComponent *> * _Nonnull primaryTextComponents;
        [Export("primaryTextComponents", ArgumentSemantic.Copy)]
        MBVisualInstructionComponent[] PrimaryTextComponents { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable secondaryText;
        [NullAllowed, Export("secondaryText")]
        string SecondaryText { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBVisualInstructionComponent *> * _Nullable secondaryTextComponents;
        [NullAllowed, Export("secondaryTextComponents", ArgumentSemantic.Copy)]
        MBVisualInstructionComponent[] SecondaryTextComponents { get; }

        /// Indicates what side of a bidirectional road the driver must be driving on. Also referred to as the rule of the road.
        //@property(nonatomic) enum MBDrivingSide drivingSide;
        [Export("drivingSide")]
        MBDrivingSide DrivingSide { get; }

        // -(instancetype _Nonnull)initWithJson:(NSDictionary<NSString *,id> * _Nonnull)json;
        [Export("initWithJson:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json);

        // -(instancetype _Nonnull)initWithDistanceAlongStep:(CLLocationDistance)distanceAlongStep primaryText:(NSString * _Nonnull)primaryText primaryTextComponents:(NSArray<MBVisualInstructionComponent *> * _Nonnull)primaryTextComponents secondaryText:(NSString * _Nullable)secondaryText secondaryTextComponents:(NSArray<MBVisualInstructionComponent *> * _Nullable)secondaryTextComponents __attribute__((objc_designated_initializer));
        [Export("initWithDistanceAlongStep:primaryText:primaryTextComponents:secondaryText:secondaryTextComponents:")]
        [DesignatedInitializer]
        IntPtr Constructor(double distanceAlongStep, string primaryText, MBVisualInstructionComponent[] primaryTextComponents, [NullAllowed] string secondaryText, [NullAllowed] MBVisualInstructionComponent[] secondaryTextComponents);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    // @interface MBVisualInstructionComponent : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBVisualInstructionComponent : INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; }

        // @property (copy, nonatomic) NSURL * _Nullable imageURL;
        [NullAllowed, Export("imageURL", ArgumentSemantic.Copy)]
        NSUrl ImageURL { get; set; }

        /// The type of visual instruction component. You can display the component differently depending on its type.
        //@property(nonatomic) enum MBVisualInstructionComponentType type;
        [Export("type")]
        MBVisualInstructionComponentType Type { get; }

        /// :nodoc:
        /// The maneuver type for the <code>VisualInstruction</code>.
        //@property(nonatomic) enum MBManeuverType maneuverType;
        [Export("maneuverType")]
        MBManeuverType ManeuverType { get; }

        /// :nodoc:
        /// The modifier type for the <code>VisualInstruction</code>.
        //@property(nonatomic) enum MBManeuverDirection maneuverDirection;
        [Export("maneuverDirection")]
        MBManeuverDirection ManeuverDirection { get; }

        /// An abbreviated version of the text for a given component.
        //@property(nonatomic, copy) NSString* _Nullable abbreviation;
        [Export("abbreviation")]
        string Abbreviation { get; }

        /// The priority in which the component should be abbreviated. Lower numbers should be abbreviated first.
        //@property(nonatomic) NSInteger abbreviationPriority;
        [Export("abbreviationPriority")]
        nint AbbreviationPriority { get; }

        //- (nonnull instancetype)initWithManeuverType:(enum MBManeuverType)maneuverType maneuverDirection:(enum MBManeuverDirection)maneuverDirection json:(NSDictionary<NSString *, id> * _Nonnull)json;
        [Export("initWithManeuverType:maneuverDirection:json:")]
        IntPtr Constructor(MBManeuverType maneuverType, MBManeuverDirection maneuverDirection, NSDictionary<NSString, NSObject> json);

        //- (nonnull instancetype)initWithType:(enum MBVisualInstructionComponentType)type text:(NSString * _Nullable)text imageURL:(NSURL * _Nullable)imageURL maneuverType:(enum MBManeuverType)maneuverType maneuverDirection:(enum MBManeuverDirection)maneuverDirection abbreviation:(NSString * _Nullable)abbreviation abbreviationPriority:(NSInteger)abbreviationPriority OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithType:text:imageURL:maneuverType:maneuverDirection:abbreviation:abbreviationPriority:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBVisualInstructionComponentType type, [NullAllowed] string text, [NullAllowed] NSUrl imageURL, MBManeuverType maneuverType, MBManeuverDirection maneuverDirection, string abbreviation, nint abbreviationPriority);

        // @property (nonatomic, class) BOOL supportsSecureCoding;
        [Static]
        [Export("supportsSecureCoding")]
        bool SupportsSecureCoding { get; set; }

    }

    /// <summary>
    /// A <code>Waypoint</code> object indicates a location along a route. It may be the route’s origin or destination, or it may be another location that the route visits. A waypoint object indicates the location’s geographic location along with other optional information, such as a name or the user’s direction approaching the waypoint. You create a <code>RouteOptions</code> object using waypoint objects and also receive waypoint objects in the completion handler of the <code>Directions.calculate(_:completionHandler:)</code> method.
    /// </summary>
    //@interface MBWaypoint : NSObject<NSCopying, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBWaypoint : INSCopying, INSSecureCoding
    {
        /// <summary>
        /// Initializes a new waypoint object with the given geographic coordinate and an optional accuracy and name.
        /// </summary>
        /// <param name="coordinate">
        /// The geographic coordinate of the waypoint.
        /// </param>
        /// <param name="coordinateAccuracy">
        /// The maximum distance away from the waypoint that the route may come and still be considered viable. This parameter is measured in meters. A negative value means the route may be an indefinite number of meters away from the route and still be considered viable.
        /// It is recommended that the value of this parameter be greater than the <code>horizontalAccuracy</code> property of a <code>CLLocation</code> object obtained from a <code>CLLocationManager</code> object. There is a high likelihood that the user may be located some distance away from a navigable road, for instance if the user is currently on a driveway or inside a building.
        /// </param>
        /// <param name="name"> 
        /// This parameter does not affect the route but may help you to distinguish one waypoint from another.
        /// </param>
        // - (nonnull instancetype) initWithCoordinate:(CLLocationCoordinate2D) coordinate coordinateAccuracy:(CLLocationAccuracy) coordinateAccuracy name:(NSString* _Nullable) name OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithCoordinate:coordinateAccuracy:name:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocationCoordinate2D coordinate, double coordinateAccuracy, [NullAllowed] string name);

        /// <summary>
        /// Initializes a new waypoint object with the given <code>CLLocation</code> object and an optional <code>CLHeading</code> object and name.
        /// </summary>
        /// <remarks>
        /// This initializer is intended for <code>CLLocation</code> objects created using the <code>CLLocation.init(latitude:longitude:)</code> initializer. If you intend to use a <code>CLLocation</code> object obtained from a <code>CLLocationManager</code> object, consider increasing the <code>horizontalAccuracy</code> or set it to a negative value to avoid overfitting, since the <code>Waypoint</code> class’s <code>coordinateAccuracy</code> property represents the maximum allowed deviation from the waypoint. There is a high likelihood that the user may be located some distance away from a navigable road, for instance if the user is currently on a driveway of inside a building.
        /// </remarks>
        /// <param name="location">
        /// A <code>CLLocation</code> object representing the waypoint’s location. This initializer respects the <code>CLLocation</code> class’s <code>coordinate</code> and <code>horizontalAccuracy</code> properties, converting them into the <code>coordinate</code> and <code>coordinateAccuracy</code> properties, respectively.
        /// </param>
        /// <param name="heading">
        /// A <code>CLHeading</code> object representing the direction from which the route must approach the waypoint in order to be considered viable. This initializer respects the <code>CLHeading</code> class’s <code>trueHeading</code> property or <code>magneticHeading</code> property, converting it into the <code>headingAccuracy</code> property.
        /// </param>
        /// <param name="name"> 
        /// The name of the waypoint. This parameter does not affect the route but may help you to distinguish one waypoint from another.
        /// </param>
        //- (nonnull instancetype) initWithLocation:(CLLocation* _Nonnull) location heading:(CLHeading* _Nullable) heading name:(NSString* _Nullable) name OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithLocation:heading:name:")]
        [DesignatedInitializer]
        IntPtr Constructor(CLLocation location, [NullAllowed] CLHeading heading, [NullAllowed] string name);

        /// <summary>
        /// The geographic coordinate of the waypoint.
        /// </summary>
        //@property(nonatomic, readonly) CLLocationCoordinate2D coordinate;
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        /// <summary>
        /// The radius of uncertainty for the waypoint, measured in meters.
        /// For a route to be considered viable, it must enter this waypoint’s circle of uncertainty. The <code>coordinate</code> property identifies the center of the circle, while this property indicates the circle’s radius. If the value of this property is negative, a route is considered viable regardless of whether it enters this waypoint’s circle of uncertainty, subject to an undefined maximum distance.
        /// By default, the value of this property is a negative number.
        /// </summary>
        //@property(nonatomic) CLLocationAccuracy coordinateAccuracy;
        [Export("coordinateAccuracy")]
        double CoordinateAccuracy { get; set; }

        /// <summary>
        /// The direction from which a route must approach this waypoint in order to be considered viable.
        /// This property is measured in degrees clockwise from true north. A value of 0 degrees means due north, 90 degrees means due east, 180 degrees means due south, and so on. If the value of this property is negative, a route is considered viable regardless of the direction from which it approaches this waypoint.
        /// If this waypoint is the first waypoint (the source waypoint), the route must start out by heading in the direction specified by this property. You should always set the <code>headingAccuracy</code> property in conjunction with this property. If the <code>headingAccuracy</code> property is set to a negative value, this property is ignored.
        /// For driving directions, this property can be useful for avoiding a route that begins by going in the direction opposite the current direction of travel. For example, if you know the user is moving eastwardly and the first waypoint is the user’s current location, specifying a heading of 90 degrees and a heading accuracy of 90 degrees for the first waypoint avoids a route that begins with a “head west” instruction.
        /// You should be certain that the user is in motion before specifying a heading and heading accuracy; otherwise, you may be unnecessarily filtering out the best route. For example, suppose the user is sitting in a car parked in a driveway, facing due north, with the garage in front and the street to the rear. In that case, specifying a heading of 0 degrees and a heading accuracy of 90 degrees may result in a route that begins on the back alley or, worse, no route at all. For this reason, it is recommended that you only specify a heading and heading accuracy when automatically recalculating directions due to the user deviating from the route.
        /// By default, the value of this property is a negative number, meaning that a route is considered viable regardless of the direction of approach.
        /// </summary>
        //@property(nonatomic) CLLocationDirection heading;
        [Export("heading")]
        double Heading { get; set; }

        /// <summary>
        /// The maximum amount, in degrees, by which a route’s approach to a waypoint may differ from <code>heading</code> in either direction in order to be considered viable.
        /// A value of 0 degrees means that the approach must match the specified <code>heading</code> exactly – an unlikely scenario. A value of 180 degrees or more means that the approach may be as much as 180 degrees in either direction from the specified <code>heading</code>, effectively allowing a candidate route to approach the waypoint from any direction.
        /// If you set the <code>heading</code> property, you should set this property to a value such as 90 degrees, to avoid filtering out routes whose approaches differ only slightly from the specified <code>heading</code>. Otherwise, if the <code>heading</code> property is set to a negative value, this property is ignored.
        /// By default, the value of this property is a negative number, meaning that a route is considered viable regardless of the direction of approach.
        /// </summary>
        //@property(nonatomic) CLLocationDirection headingAccuracy;
        [Export("headingAccuracy")]
        double HeadingAccuracy { get; set; }

        /// <summary>
        /// The name of the waypoint.
        /// This parameter does not affect the route, but you can set the name of a waypoint you pass into a <code>RouteOptions</code> object to help you distinguish one waypoint from another in the array of waypoints passed into the completion handler of the <code>Directions.calculate(_:completionHandler:)</code> method.
        /// </summary>
        //@property(nonatomic, copy) NSString* _Nullable name;
        [Export("name")]
        string Name { get; set; }

        /// <summary>
        /// </summary>
        //@property(nonatomic, readonly, copy) NSString* _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    /// <summary>
    /// A <code>Tracepoint</code> represents a location matched to the road network.
    //SWIFT_CLASS_NAMED("Tracepoint")
    //@interface MBTracepoint : MBWaypoint
    [BaseType(typeof(MBWaypoint))]
    [DisableDefaultCtor]
    partial interface MBTracepoint
    {
        /// <summary>
        /// Number of probable alternative matchings for this tracepoint. A value of zero indicates that this point was matched unambiguously.
        /// </summary>
        //@property(nonatomic) NSInteger alternateCount;
        [Export("alternateCount")]
        nint AlternateCount { get; set; }
    }

    /// <summary>
    /// Options for calculating results from the Mapbox Directions service.
    /// You do not create instances of this class directly. Instead, create instances of <code>MatchOptions</code> or <code>RouteOptions</code>.
    /// </summary>
    //SWIFT_CLASS_NAMED("DirectionsOptions")
    //@interface MBDirectionsOptions : NSObject<NSCopying, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBDirectionsOptions : INSCopying, INSSecureCoding
    {
        /// <summary>
        /// Initializes a route options object for routes between the given waypoints and an optional profile identifier.
        /// </summary>
        /// <param name="waypoints">
        /// An array of <code>Waypoint</code> objects representing locations that the route should visit in chronological order. The array should contain at least two waypoints (the source and destination) and at most 25 waypoints. (Some profiles, such as <code>MBDirectionsProfileIdentifierAutomobileAvoidingTraffic</code>, <a href="https://www.mapbox.com/api-documentation/#directions">may have lower limits</a>.)
        /// </param>
        /// <param name="profileIdentifier">
        /// A string specifying the primary mode of transportation for the routes. This parameter, if set, should be set to <code>MBDirectionsProfileIdentifierAutomobile</code>, <code>MBDirectionsProfileIdentifierAutomobileAvoidingTraffic</code>, <code>MBDirectionsProfileIdentifierCycling</code>, or <code>MBDirectionsProfileIdentifierWalking</code>. <code>MBDirectionsProfileIdentifierAutomobile</code> is used by default.
        /// </param>
        //- (nonnull instancetype) initWithWaypoints:(NSArray<MBWaypoint*>* _Nonnull) waypoints profileIdentifier:(MBDirectionsProfileIdentifier _Nullable) profileIdentifier OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithWaypoints:profileIdentifier:"), DesignatedInitializer]
        IntPtr Constructor(MBWaypoint[] waypoints, string profileIdentifier);

        //- (BOOL) isEqual:(id _Nullable) object SWIFT_WARN_UNUSED_RESULT;
        [Export("isEqual:")]
        bool IsEqual(NSObject obj);

        //- (BOOL) isEqualToDirectionsOptions:(MBDirectionsOptions* _Nullable) directionsOptions SWIFT_WARN_UNUSED_RESULT;
        [Export("isEqualToDirectionsOptions:")]
        bool IsEqual(MBDirectionsOptions obj);

        /// <summary>
        /// An array of <code>Waypoint</code> objects representing locations that the route should visit in chronological order.
        /// A waypoint object indicates a location to visit, as well as an optional heading from which to approach the location.
        /// The array should contain at least two waypoints (the source and destination) and at most 25 waypoints.
        /// </summary>
        //@property(nonatomic, copy) NSArray<MBWaypoint*>* _Nonnull waypoints;
        [Export("waypoints")]
        MBWaypoint Waypoints { get; set; }

        /// <summary>
        /// A string specifying the primary mode of transportation for the routes.
        /// This property should be set to <code>MBDirectionsProfileIdentifierAutomobile</code>, <code>MBDirectionsProfileIdentifierAutomobileAvoidingTraffic</code>, <code>MBDirectionsProfileIdentifierCycling</code>, or <code>MBDirectionsProfileIdentifierWalking</code>. The default value of this property is <code>MBDirectionsProfileIdentifierAutomobile</code>, which specifies driving directions.
        /// </summary>
        //@property(nonatomic) MBDirectionsProfileIdentifier _Nonnull profileIdentifier;
        [Export("profileIdentifier")]
        string ProfileIdentifier { get; set; }

        /// <summary>
        /// A Boolean value indicating whether <code>MBRouteStep</code> objects should be included in the response.
        /// If the value of this property is <code>true</code>, the returned route contains turn-by-turn instructions. Each returned <code>MBRoute</code> object contains one or more <code>MBRouteLeg</code> object that in turn contains one or more <code>MBRouteStep</code> objects. On the other hand, if the value of this property is <code>false</code>, the <code>MBRouteLeg</code> objects contain no <code>MBRouteStep</code> objects.
        /// If you only want to know the distance or estimated travel time to a destination, set this property to <code>false</code> to minimize the size of the response and the time it takes to calculate the response. If you need to display turn-by-turn instructions, set this property to <code>true</code>.
        /// The default value of this property is <code>false</code>.
        /// </summary>
        //@property(nonatomic) BOOL includesSteps;
        [Export("includesSteps")]
        bool IncludesSteps { get; set; }

        /// <summary>
        /// Format of the data from which the shapes of the returned route and its steps are derived.
        /// This property has no effect on the returned shape objects, although the choice of format can significantly affect the size of the underlying HTTP response.
        /// The default value of this property is <code>polyline</code>.
        /// </summary>
        //@property(nonatomic) enum MBRouteShapeFormat shapeFormat;
        [Export("shapeFormat")]
        MBRouteShapeFormat shapeFormat { get; set; }

        /// <summary>
        /// Resolution of the shape of the returned route.
        /// This property has no effect on the shape of the returned route’s steps.
        /// The default value of this property is <code>low</code>, specifying a low-resolution route shape.
        /// </summary>
        //@property(nonatomic) enum MBRouteShapeResolution routeShapeResolution;
        [Export("routeShapeResolution")]
        MBRouteShapeResolution routeShapeResolution { get; set; }

        /// <summary>
        /// AttributeOptions for the route. Any combination of <code>AttributeOptions</code> can be specified.
        /// By default, no attribute options are specified. It is recommended that <code>routeShapeResolution</code> be set to <code>.full</code>.
        /// </summary>
        //@property(nonatomic) MBAttributeOptions attributeOptions;
        [Export("attributeOptions")]
        MBAttributeOptions AttributeOptions { get; set; }

        /// <summary>
        /// The locale in which the route’s instructions are written.
        /// If you use MapboxDirections.swift with the Mapbox Directions API or Map Matching API, this property affects the sentence contained within the <code>RouteStep.instructions</code> property, but it does not affect any road names contained in that property or other properties such as <code>RouteStep.name</code>.
        /// The Directions API can provide instructions in <a href="https://www.mapbox.com/api-documentation/#instructions-languages">a number of languages</a>. Set this property to <code>Bundle.main.preferredLocalizations.first</code> or <code>Locale.autoupdatingCurrent</code> to match the application’s language or the system language, respectively.
        /// By default, this property is set to the current system locale.
        /// </summary>
        //@property(nonatomic, copy) NSLocale* _Nonnull locale;
        [Export("locale")]
        NSLocale Locale { get; set; }

        /// <summary>
        /// A Boolean value indicating whether each route step includes an array of <code>SpokenInstructions</code>.
        /// If this option is set to true, the <code>RouteStep.instructionsSpokenAlongStep</code> property is set to an array of <code>SpokenInstructions</code>.
        /// </summary>
        //@property(nonatomic) BOOL includesSpokenInstructions;
        [Export("includesSpokenInstructions")]
        bool IncludesSpokenInstructions { get; set; }

        /// <summary>
        /// The measurement system used in spoken instructions included in route steps.
        /// If the <code>includesSpokenInstructions</code> property is set to <code>true</code>, this property determines the units used for measuring the distance remaining until an upcoming maneuver. If the <code>includesSpokenInstructions</code> property is set to <code>false</code>, this property has no effect.
        /// You should choose a measurement system appropriate for the current region. You can also allow the user to indicate their preferred measurement system via a setting.
        /// </summary>
        //@property(nonatomic) enum MBMeasurementSystem distanceMeasurementSystem;
        [Export("distanceMeasurementSystem")]
        nint DistanceMeasurementSystem { get; set; }

        /// <summary>
        /// If true, each <code>RouteStep</code> will contain the property <code>visualInstructionsAlongStep</code>.
        /// <code>visualInstructionsAlongStep</code> contains an array of <code>VisualInstruction</code> used for visually conveying information about a given <code>RouteStep</code>.
        /// </summary>
        //@property(nonatomic) BOOL includesVisualInstructions;
        [Export("includesVisualInstructions")]
        bool IncludesVisualInstructions { get; set; }
    }

    /// <summary>
    /// A <code>DirectionsResult</code> represents a result returned from either the Mapbox Directions service.
    /// You do not create instances of this class directly. Instead, you receive <code>Route</code> or <code>Match</code> objects when you request directions using the <code>Directions.calculate(_:completionHandler:)</code> or <code>Directions.calculateRoutes(matching:completionHandler:)</code> method.
    /// </summary>
    //SWIFT_CLASS_NAMED("DirectionsResult")
    //@interface MBDirectionsResult : NSObject<NSSecureCoding>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBDirectionsResult : INSSecureCoding
    {
        /// <summary>
        /// An array of geographic coordinates defining the path of the route from start to finish.
        /// This array may be <code>nil</code> or simplified depending on the <code>routeShapeResolution</code> property of the original <code>RouteOptions</code> object.
        /// Using the <a href="https://www.mapbox.com/ios-sdk/">Mapbox Maps SDK for iOS</a> or <a href="https://github.com/mapbox/mapbox-gl-native/tree/master/platform/macos/">Mapbox Maps SDK for macOS</a>, you can create an <code>MGLPolyline</code> object using these coordinates to display an overview of the route on an <code>MGLMapView</code>.
        /// </summary>
        //@property(nonatomic, readonly, copy) NSArray<NSValue*>* _Nullable coordinates;
        [Export("coordinates")]
        NSValue[] Coordinates { get; set; }

        /// <summary>
        /// The number of coordinates.
        /// The value of this property may be zero or reduced depending on the <code>routeShapeResolution</code> property of the original <code>RouteOptions</code> object.
        /// note:
        /// This initializer is intended for Objective-C usage. In Swift code, use the <code>coordinates.count</code> property.
        /// </summary>
        //@property(nonatomic, readonly) NSUInteger coordinateCount;
        [Export("coordinateCount")]
        nuint CoordinateCount { get; set; }

        /// <summary>
        /// Retrieves the coordinates.
        /// The array may be empty or simplified depending on the <code>routeShapeResolution</code> property of the original <code>RouteOptions</code> object.
        /// Using the <a href="https://www.mapbox.com/ios-sdk/">Mapbox Maps SDK for iOS</a> or <a href="https://github.com/mapbox/mapbox-gl-native/tree/master/platform/macos/">Mapbox Maps SDK for macOS</a>, you can create an <code>MGLPolyline</code> object using these coordinates to display an overview of the route on an <code>MGLMapView</code>.
        /// precondition:
        /// <code>coordinates</code> must be large enough to hold <code>coordinateCount</code> instances of <code>CLLocationCoordinate2D</code>.
        /// note:
        /// This initializer is intended for Objective-C usage. In Swift code, use the <code>coordinates</code> property.
        /// \param coordinates A pointer to a C array of <code>CLLocationCoordinate2D</code> instances. On output, this array contains all the vertices of the overlay.
        /// </summary>
        //- (void) getCoordinates:(CLLocationCoordinate2D* _Nonnull) coordinates;
        [Export("getCoordinates:")]
        void GetCoordinates(CLLocationCoordinate2D coordinates);

        /// <summary>
        /// An array of <code>RouteLeg</code> objects representing the legs of the route.
        /// The number of legs in this array depends on the number of waypoints. A route with two waypoints (the source and destination) has one leg, a route with three waypoints (the source, an intermediate waypoint, and the destination) has two legs, and so on.
        /// To determine the name of the route, concatenate the names of the route’s legs.
        /// </summary>
        //@property(nonatomic, readonly, copy) NSArray<MBRouteLeg*>* _Nonnull legs;
        [Export("legs")]
        MBRouteLeg[] Legs { get; set; }

        //@property(nonatomic, readonly, copy) NSString* _Nonnull description;
        [Export("description")]
        string description { get; set; }

        /// <summary>
        /// The route’s distance, measured in meters.
        /// The value of this property accounts for the distance that the user must travel to traverse the path of the route. It is the sum of the <code>distance</code> properties of the route’s legs, not the sum of the direct distances between the route’s waypoints. You should not assume that the user would travel along this distance at a fixed speed.
        /// </summary>
        //@property(nonatomic, readonly) CLLocationDistance distance;
        [Export("distance")]
        double Distance { get; }

        /// <summary>
        /// The route’s expected travel time, measured in seconds.
        /// The value of this property reflects the time it takes to traverse the entire route. It is the sum of the <code>expectedTravelTime</code> properties of the route’s legs. If the route was calculated using the <code>MBDirectionsProfileIdentifierAutomobileAvoidingTraffic</code> profile, this property reflects current traffic conditions at the time of the request, not necessarily the traffic conditions at the time the user would begin the route. For other profiles, this property reflects travel time under ideal conditions and does not account for traffic congestion. If the route makes use of a ferry or train, the actual travel time may additionally be subject to the schedules of those services.
        /// </summary>
        //@property(nonatomic, readonly) NSTimeInterval expectedTravelTime;
        [Export("expectedTravelTime")]
        double ExpectedTravelTime { get; set; }

        /// <summary>
        /// <code>RouteOptions</code> used to create the directions request.
        /// The route options object’s profileIdentifier property reflects the primary mode of transportation used for the route. Individual steps along the route might use different modes of transportation as necessary.
        /// </summary>
        //@property(nonatomic, readonly, strong) MBDirectionsOptions* _Nonnull directionsOptions;
        [Export("directionsOptions")]
        MBDirectionsOptions DirectionsOptions { get; }

        /// <summary>
        /// The <a href="https://www.mapbox.com/help/define-access-token/">access token</a> used to make the directions request.
        /// This property is set automatically if a request is made via <code>Directions.calculate(_:completionHandler:)</code>.
        /// </summary>
        //@property(nonatomic, copy) NSString* _Nullable accessToken;
        [Export("accessToken")]
        string AccessToken { get; set; }

        /// <summary>
        /// The endpoint used to make the directions request.
        /// This property is set automatically if a request is made via <code>Directions.calculate(_:completionHandler:)</code>.
        /// </summary>
        //@property(nonatomic, copy) NSURL* _Nullable apiEndpoint;
        [Export("apiEndpoint")]
        NSUrl ApiEndpoint { get; set; }

        /// <summary>
        /// A unique identifier for a directions request.
        /// Each route produced by a single call to <code>Directions.calculate(_:completionHandler:)</code> has the same route identifier.
        //@property(nonatomic, copy) NSString* _Nullable routeIdentifier;
        [Export("routeIdentifier")]
        string RouteIdentifier { get; set; }

        /// <summary>
        /// The locale to use for spoken instructions.
        /// This locale is specific to Mapbox Voice API. If <code>nil</code> is returned, the instruction should be spoken with an alternative speech synthesizer.
        /// </summary>
        //@property(nonatomic, copy) NSLocale* _Nullable speechLocale;
        [Export("speechLocale")]
        NSLocale SpeechLocale { get; set; }
    }

    /// <summary>
    /// A <code>Match</code> object defines a single route that was created from a series of points that were matched against a road network.
    /// Typically, you do not create instances of this class directly. Instead, you receive match objects when you pass a <code>MatchOptions</code> object into the <code>Directions.calculate(_:completionHandler:)</code> or <code>Directions.calculateRoutes(matching:completionHandler:)</code> method.
    /// </summary>
    //SWIFT_CLASS_NAMED("Match")
    //@interface MBMatch : MBDirectionsResult
    [BaseType(typeof(MBDirectionsResult))]
    [DisableDefaultCtor]
    interface MBMatch
    {
        /// <summary>
        /// Initializes a new match object with the given JSON dictionary representation and tracepoints.
        /// </summary>
        /// <param name="json">
        /// A JSON dictionary representation of the route as returned by the Mapbox Map Matching API.
        /// </param>
        /// <param name="tracepoints">
        /// An array of <code>Tracepoint</code> that the match found in order.
        /// </param>
        /// <param name="waypointIndices"></param>
        /// <param name="matchOptions">
        /// The <code>MatchOptions</code> used to create the request.
        /// </param>
        //- (nonnull instancetype) initWithJson:(NSDictionary<NSString*, id>* _Nonnull) json tracepoints:(NSArray<MBTracepoint*>* _Nonnull) tracepoints waypointIndices:(NSIndexSet* _Nonnull) waypointIndices matchOptions:(MBMatchOptions* _Nonnull) matchOptions;
        [Export("initWithJson:tracepoints:waypointIndices:matchOptions:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> json, MBTracepoint[] tracepoints, NSIndexSet waypointIndices, MBMatchOptions matchOptions);

        /// <summary>
        /// A number between 0 and 1 that indicates the Map Matching API’s confidence that the match is accurate. A higher confidence means the match is more likely to be accurate.
        /// </summary>
        //@property(nonatomic) float confidence;
        [Export("confidence")]
        float Confidence { get; set; }

        /// <summary>
        /// Tracepoints on the road network that match the tracepoints in the match options.
        /// Any outlier tracepoint is omitted from the match. This array represents an outlier tracepoint is a <code>Tracepoint</code> object whose <code>Tracepoint.coordinate</code> property is <code>kCLLocationCoordinate2DInvalid</code>.
        /// </summary>
        //@property(nonatomic, copy) NSArray<MBTracepoint*>* _Nonnull tracepoints;
        [Export("tracepoints")]
        MBTracepoint[] Tracepoints { get; set; }

        /// <summary>
        /// Index of the waypoint inside the matched route.
        /// </summary>
        //@property(nonatomic, copy) NSIndexSet* _Nullable waypointIndices;
        [Export("waypointIndices")]
        NSIndexSet WaypointIndices { get; set; }

        //- (BOOL) isEqual:(id _Nullable) object SWIFT_WARN_UNUSED_RESULT;
        [Export("isEqual:")]
        bool IsEqual(NSObject obj);

        //- (BOOL) isEqualToMatch:(MBMatch* _Nullable) match SWIFT_WARN_UNUSED_RESULT;
        [Export("isEqualToMatch:")]
        bool IsEqual(MBMatch obj);
    }

    /// <summary>
    /// A <code>MatchOptions</code> object is a structure that specifies the criteria for results returned by the Mapbox Map Matching API.
    /// Pass an instance of this class into the <code>Directions.calculate(_:completionHandler:)</code> method.
    /// </summary>
    //SWIFT_CLASS_NAMED("MatchOptions")
    //@interface MBMatchOptions : MBDirectionsOptions
    [BaseType(typeof(MBDirectionsOptions))]
    [DisableDefaultCtor]
    interface MBMatchOptions
    {
        //- (nonnull instancetype) initWithWaypoints:(NSArray<MBWaypoint*>* _Nonnull) waypoints profileIdentifier:(MBDirectionsProfileIdentifier _Nullable) profileIdentifier OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithWaypoints:profileIdentifier:"), DesignatedInitializer]
        IntPtr Constructor(MBWaypoint[] waypoints, string profileIdentifier);

        /// <summary>
        /// If true, the input locations are re-sampled for improved map matching results. The default is  <code>false</code>.
        /// </summary>
        // @property(nonatomic) BOOL resamplesTraces;
        [Export("resamplesTraces")]
        bool ResamplesTraces { get; set; }

        /// <summary>
        /// An index set containing indices of two or more items in <code>coordinates</code>. These will be represented by <code>Waypoint</code>s in the resulting <code>Match</code> objects.
        /// Use this property when the <code>includesSteps</code> property is <code>true</code> or when <code>coordinates</code> represents a trace with a high sample rate. If this property is <code>nil</code>, the resulting <code>Match</code> objects contain a waypoint for each coordinate in the match options.
        /// If specified, each index must correspond to a valid index in <code>coordinates</code>, and the index set must contain 0 and the last index (one less than <code>endIndex</code>) of <code>coordinates</code>.
        /// </summary>
        // @property(nonatomic, copy) NSIndexSet* _Nullable waypointIndices;
        [Export("waypointIndices")]
        NSIndexSet WaypointIndices { get; set; }
    }
}
