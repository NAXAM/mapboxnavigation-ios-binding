using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

using MapboxDirections;

namespace MapboxCoreNavigation
{
    [Static]
    partial interface MBRouteControllerConstants
    {
        // extern NSString *const MBRouteControllerProgressDidChangeNotificationProgressKey;
        [Field ("MBRouteControllerProgressDidChangeNotificationProgressKey", "__Internal")]
        NSString ProgressDidChangeNotificationProgressKey { get; }

        // extern NSString *const MBRouteControllerProgressDidChangeNotificationLocationKey;
        [Field ("MBRouteControllerProgressDidChangeNotificationLocationKey", "__Internal")]
        NSString ProgressDidChangeNotificationLocationKey { get; }

        // extern NSString *const MBRouteControllerProgressDidChangeNotificationSecondsRemainingOnStepKey;
        [Field ("MBRouteControllerProgressDidChangeNotificationSecondsRemainingOnStepKey", "__Internal")]
        NSString ProgressDidChangeNotificationSecondsRemainingOnStepKey { get; }

        // extern NSString *const MBRouteControllerDidPassSpokenInstructionPointRouteProgressKey;
        [Field ("MBRouteControllerDidPassSpokenInstructionPointRouteProgressKey", "__Internal")]
        NSString DidPassSpokenInstructionPointRouteProgressKey { get; }

        // extern NSString *const MBRouteControllerDidPassSpokenInstructionPoint;
        [Field ("MBRouteControllerDidPassSpokenInstructionPoint", "__Internal")]
        NSString DidPassSpokenInstructionPoint { get; }

        // extern NSString *const MBRouteControllerNotificationLocationKey;
        [Field ("MBRouteControllerNotificationLocationKey", "__Internal")]
        NSString NotificationLocationKey { get; }

        // extern NSString *const MBRouteControllerNotificationRouteKey;
        [Field ("MBRouteControllerNotificationRouteKey", "__Internal")]
        NSString NotificationRouteKey { get; }

        // extern NSString *const MBRouteControllerNotificationErrorKey;
        [Field ("MBRouteControllerNotificationErrorKey", "__Internal")]
        NSString NotificationErrorKey { get; }

        // extern NSString *const MBRouteControllerNotificationProgressDidChange;
        [Field ("MBRouteControllerNotificationProgressDidChange", "__Internal")]
        NSString NotificationProgressDidChange { get; }

        // extern NSString *const MBRouteControllerWillReroute;
        [Field ("MBRouteControllerWillReroute", "__Internal")]
        NSString WillReroute { get; }

        // extern NSString *const MBRouteControllerDidReroute;
        [Field ("MBRouteControllerDidReroute", "__Internal")]
        NSString DidReroute { get; }

        // extern NSString *const MBRouteControllerDidFailToReroute;
        [Field ("MBRouteControllerDidFailToReroute", "__Internal")]
        NSString DidFailToReroute { get; }

        // extern NSString *const MBRouteControllerDidFindFasterRouteKey;
        [Field ("MBRouteControllerDidFindFasterRouteKey", "__Internal")]
        NSString DidFindFasterRouteKey { get; }

        // extern NSString *const MBErrorDomain;
        [Field ("MBErrorDomain", "__Internal")]
        NSString MBErrorDomain { get; }

        // extern NSString *const MBSpokenInstructionErrorCodeKey;
        [Field ("MBSpokenInstructionErrorCodeKey", "__Internal")]
        NSString MBSpokenInstructionErrorCodeKey { get; }
    }

    // @interface MBDistanceFormatter : NSLengthFormatter
    [BaseType (typeof(NSLengthFormatter))]
    [DisableDefaultCtor]
    interface MBDistanceFormatter
    {
        // -(instancetype _Nonnull)initWithApproximate:(BOOL)approximate __attribute__((objc_designated_initializer));
        [Export ("initWithApproximate:")]
        [DesignatedInitializer]
        IntPtr Constructor (bool approximate);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export ("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor (NSCoder decoder);

        // -(NSString * _Nonnull)stringFrom:(CLLocationDistance)distance __attribute__((warn_unused_result));
        [Export ("stringFrom:")]
        string StringFrom (double distance);

        // -(NSString * _Nonnull)stringFromMeters:(double)numberInMeters __attribute__((warn_unused_result));
        [Export ("stringFromMeters:")]
        string StringFromMeters (double numberInMeters);
    }

    // @interface MBNavigationLocationManager : CLLocationManager
    [BaseType (typeof(CLLocationManager))]
    interface MBNavigationLocationManager
    {
    }

    // @interface MBNavigationRouteOptions
    [BaseType(typeof(MBRouteOptions))]
    interface MBNavigationRouteOptions
    {
        // -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(id)profileIdentifier __attribute__((objc_designated_initializer));
        [Export ("initWithWaypoints:profileIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBWaypoint[] waypoints, NSObject profileIdentifier);

        // -(instancetype _Nonnull)initWithLocations:(NSArray<CLLocation *> * _Nonnull)locations profileIdentifier:(id)profileIdentifier;
        [Export ("initWithLocations:profileIdentifier:")]
        IntPtr Constructor (CLLocation[] locations, NSObject profileIdentifier);

        // -(instancetype _Nonnull)initWithCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates profileIdentifier:(id)profileIdentifier;
        [Export ("initWithCoordinates:profileIdentifier:")]
        IntPtr Constructor (NSValue[] coordinates, NSObject profileIdentifier);
    }

    // @interface MBReplayLocationManager : MBNavigationLocationManager
    [BaseType (typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBReplayLocationManager
    {
        // @property (nonatomic) NSTimeInterval speedMultiplier;
        [Export ("speedMultiplier")]
        double SpeedMultiplier { get; set; }

        // @property (copy, nonatomic) NSArray<CLLocation *> * _Null_unspecified locations;
        [Export ("locations", ArgumentSemantic.Copy)]
        CLLocation[] Locations { get; set; }

        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(void)startUpdatingLocation;
        [Export ("startUpdatingLocation")]
        void StartUpdatingLocation ();

        // -(void)stopUpdatingLocation;
        [Export ("stopUpdatingLocation")]
        void StopUpdatingLocation ();
    }

    // @interface MBRouteController : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    partial interface MBRouteController
    {
        [Wrap ("WeakDelegate")]
        [NullAllowed]
        MBRouteControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MBRouteControllerDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) MBDirections * _Nonnull directions;
        [Export ("directions", ArgumentSemantic.Strong)]
        MBDirections Directions { get; set; }

        // @property (nonatomic, strong) MBNavigationLocationManager * _Null_unspecified locationManager;
        [Export ("locationManager", ArgumentSemantic.Strong)]
        MBNavigationLocationManager NavigationLocationManager { get; set; }

        // @property (nonatomic) BOOL isDeadReckoningEnabled;
        [Export ("isDeadReckoningEnabled")]
        bool IsDeadReckoningEnabled { get; set; }

        // @property (nonatomic) BOOL reroutesOpportunistically;
        [Export ("reroutesOpportunistically")]
        bool ReroutesOpportunistically { get; set; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route directions:(MBDirections * _Nonnull)directions locationManager:(MBNavigationLocationManager * _Nonnull)locationManager __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:directions:locationManager:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route, MBDirections directions, MBNavigationLocationManager locationManager);

        // -(void)resume;
        [Export ("resume")]
        void Resume ();

        // -(void)suspendLocationUpdates;
        [Export ("suspendLocationUpdates")]
        void SuspendLocationUpdates ();

        // @property (readonly, nonatomic) CLLocationDistance reroutingTolerance;
        [Export ("reroutingTolerance")]
        double ReroutingTolerance { get; }

        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(NSString * _Nonnull)recordFeedbackWithType:(enum MBFeedbackType)type description:(NSString * _Nullable)description __attribute__((warn_unused_result));
        [Export ("recordFeedbackWithType:description:")]
        string RecordFeedbackWithType (MBFeedbackType type, [NullAllowed] string description);

        // -(void)updateFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId type:(enum MBFeedbackType)type source:(enum MBFeedbackSource)source description:(NSString * _Nullable)description;
        [Export ("updateFeedbackWithFeedbackId:type:source:description:")]
        void UpdateFeedbackWithFeedbackId (string feedbackId, MBFeedbackType type, MBFeedbackSource source, [NullAllowed] string description);

        // -(void)cancelFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId;
        [Export ("cancelFeedbackWithFeedbackId:")]
        void CancelFeedbackWithFeedbackId (string feedbackId);
    }

    // @interface MapboxCoreNavigation_Swift_362 (MBRouteController) <CLLocationManagerDelegate>
    partial interface MBRouteController : ICLLocationManagerDelegate
    {
        // -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export ("locationManager:didUpdateLocations:")]
        void LocationManager (CLLocationManager manager, CLLocation[] locations);

        // -(BOOL)userIsOnRoute:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export ("userIsOnRoute:")]
        bool UserIsOnRoute (CLLocation location);
    }

    // @protocol MBRouteControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MBRouteControllerDelegate
    {
        // @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export ("routeController:shouldRerouteFromLocation:")]
        bool RouteController_shouldRerouteFromLocation (MBRouteController routeController, CLLocation location);

        // @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export ("routeController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool RouteController_shouldIncrementLegWhenArrivingAtWaypoint (MBRouteController routeController, MBWaypoint waypoint);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export ("routeController:willRerouteFromLocation:")]
        void RouteController_willRerouteFromLocation (MBRouteController routeController, CLLocation location);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didDiscardLocation:(CLLocation * _Nonnull)location;
        [Export ("routeController:didDiscardLocation:")]
        void RouteController_didDiscardLocation (MBRouteController routeController, CLLocation location);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export ("routeController:didRerouteAlongRoute:")]
        void RouteController_didRerouteAlongRoute (MBRouteController routeController, MBRoute route);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export ("routeController:didFailToRerouteWithError:")]
        void RouteController_didFailToRerouteWithError (MBRouteController routeController, NSError error);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export ("routeController:didUpdateLocations:")]
        void RouteController_didUpdateLocations (MBRouteController routeController, CLLocation[] locations);
    }

    // @interface MBRouteLegProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteLegProgress
    {
        // @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull leg;
        [Export ("leg", ArgumentSemantic.Strong)]
        MBRouteLeg Leg { get; }

        // @property (nonatomic) NSInteger stepIndex;
        [Export ("stepIndex")]
        nint StepIndex { get; set; }

        // @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (nonatomic) BOOL userHasArrivedAtWaypoint;
        [Export ("userHasArrivedAtWaypoint")]
        bool UserHasArrivedAtWaypoint { get; set; }

        // -(MBRouteStep * _Nullable)stepBefore:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("stepBefore:")]
        [return: NullAllowed]
        MBRouteStep StepBefore (MBRouteStep step);

        // -(MBRouteStep * _Nullable)stepAfter:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("stepAfter:")]
        [return: NullAllowed]
        MBRouteStep StepAfter (MBRouteStep step);

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable priorStep;
        [NullAllowed, Export ("priorStep", ArgumentSemantic.Strong)]
        MBRouteStep PriorStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull currentStep;
        [Export ("currentStep", ArgumentSemantic.Strong)]
        MBRouteStep CurrentStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable upComingStep;
        [NullAllowed, Export ("upComingStep", ArgumentSemantic.Strong)]
        MBRouteStep UpComingStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable followOnStep;
        [NullAllowed, Export ("followOnStep", ArgumentSemantic.Strong)]
        MBRouteStep FollowOnStep { get; }

        // -(BOOL)isCurrentStep:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("isCurrentStep:")]
        bool IsCurrentStep (MBRouteStep step);

        // @property (nonatomic, strong) MBRouteStepProgress * _Nonnull currentStepProgress;
        [Export ("currentStepProgress", ArgumentSemantic.Strong)]
        MBRouteStepProgress CurrentStepProgress { get; set; }

        // -(instancetype _Nonnull)initWithLeg:(MBRouteLeg * _Nonnull)leg stepIndex:(NSInteger)stepIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithLeg:stepIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRouteLeg leg, nint stepIndex, nint spokenInstructionIndex);

        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nonnull nearbyCoordinates;
        [Export ("nearbyCoordinates", ArgumentSemantic.Copy)]
        NSValue[] NearbyCoordinates { get; }
    }

    // @interface MBRouteProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteProgress
    {
        // @property (readonly, nonatomic, strong) MBRoute * _Nonnull route;
        [Export ("route", ArgumentSemantic.Strong)]
        MBRoute Route { get; }

        // @property (nonatomic) NSInteger legIndex;
        [Export ("legIndex")]
        nint LegIndex { get; set; }

        // @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull currentLeg;
        [Export ("currentLeg", ArgumentSemantic.Strong)]
        MBRouteLeg CurrentLeg { get; }

        // @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export ("distanceRemaining")]
        double DistanceRemaining { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBWaypoint *> * _Nonnull remainingWaypoints;
        [Export ("remainingWaypoints", ArgumentSemantic.Copy)]
        MBWaypoint[] RemainingWaypoints { get; }

        // @property (nonatomic, strong) MBRouteLegProgress * _Null_unspecified currentLegProgress;
        [Export ("currentLegProgress", ArgumentSemantic.Strong)]
        MBRouteLegProgress CurrentLegProgress { get; set; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route legIndex:(NSInteger)legIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:legIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route, nint legIndex, nint spokenInstructionIndex);
    }

    // @interface MBRouteStepFormatter : NSFormatter
    [BaseType (typeof(NSFormatter))]
    interface MBRouteStepFormatter
    {
        // -(NSString * _Nullable)stringForObjectValue:(id _Nullable)obj __attribute__((warn_unused_result));
        [Export ("stringForObjectValue:")]
        [return: NullAllowed]
        string StringForObjectValue ([NullAllowed] NSObject obj);

        // -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error __attribute__((warn_unused_result));
        [Export ("getObjectValue:forString:errorDescription:")]
        bool GetObjectValue ([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export ("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor (NSCoder aDecoder);
    }

    // @interface MBRouteStepProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteStepProgress
    {
        // @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull step;
        [Export ("step", ArgumentSemantic.Strong)]
        MBRouteStep Step { get; }

        // @property (nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; set; }

        // @property (nonatomic) CLLocationDistance userDistanceToManeuverLocation;
        [Export ("userDistanceToManeuverLocation")]
        double UserDistanceToManeuverLocation { get; set; }

        // @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export ("distanceRemaining")]
        double DistanceRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        // -(instancetype _Nonnull)initWithStep:(MBRouteStep * _Nonnull)step spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithStep:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRouteStep step, nint spokenInstructionIndex);

        // @property (copy, nonatomic) NSArray<MBIntersection *> * _Nullable intersectionsIncludingUpcomingManeuverIntersection;
        [NullAllowed, Export ("intersectionsIncludingUpcomingManeuverIntersection", ArgumentSemantic.Copy)]
        MBIntersection[] IntersectionsIncludingUpcomingManeuverIntersection { get; set; }

        // @property (readonly, nonatomic, strong) MBIntersection * _Nullable upcomingIntersection;
        [NullAllowed, Export ("upcomingIntersection", ArgumentSemantic.Strong)]
        MBIntersection UpcomingIntersection { get; }

        // @property (nonatomic) NSInteger intersectionIndex;
        [Export ("intersectionIndex")]
        nint IntersectionIndex { get; set; }

        // @property (nonatomic) NSInteger spokenInstructionIndex;
        [Export ("spokenInstructionIndex")]
        nint SpokenInstructionIndex { get; set; }

        // @property (readonly, nonatomic, strong) MBSpokenInstruction * _Nullable currentSpokenInstruction;
        [NullAllowed, Export ("currentSpokenInstruction", ArgumentSemantic.Strong)]
        MBSpokenInstruction CurrentSpokenInstruction { get; }
    }

    // @interface MBSimulatedLocationManager : MBNavigationLocationManager
    [BaseType (typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBSimulatedLocationManager
    {
        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route);

        // -(void)startUpdatingLocation;
        [Export ("startUpdatingLocation")]
        void StartUpdatingLocation ();

        // -(void)stopUpdatingLocation;
        [Export ("stopUpdatingLocation")]
        void StopUpdatingLocation ();
    }

    // @interface MBVisualInstructionFormatter : NSObject
    [BaseType (typeof(NSObject))]
    interface MBVisualInstructionFormatter
    {
        // -(NSString * _Nullable)stringWithLeg:(MBRouteLeg * _Nullable)leg step:(MBRouteStep * _Nullable)step __attribute__((warn_unused_result));
        [Export ("stringWithLeg:step:")]
        [return: NullAllowed]
        string StringWithLeg ([NullAllowed] MBRouteLeg leg, [NullAllowed] MBRouteStep step);
    }

}
