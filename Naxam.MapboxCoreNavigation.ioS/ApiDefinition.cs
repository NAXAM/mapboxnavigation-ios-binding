using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

using MapboxDirections;

namespace MapboxCoreNavigation
{
    [Static]
    partial interface MBNavigationSettingsNotificationKey {
        /// <summary>
        /// Posted when something changes in the shared `MBNavigationSettings` object.
        /// The user info dictionary indicates which keys and values changed.
        /// extern const NSNotificationName MBNavigationSettingsDidChangeNotification;
        /// </summary>
        [Field("MBNavigationSettingsDidChangeNotification")]
        NSString DidChangeNotification { get; }
    }

    [Static]
    partial interface MBRouteControllerNotificationKey
    {
        /// <summary>
        /// Posted when `MBRouteController` receives a user location update representing movement along the expected route.
        /// The user info dictionary contains the keys `MBRouteControllerRouteProgressKey` and `MBRouteControllerLocationKey`.
        /// </summary>
        /// extern const NSNotificationName MBRouteControllerProgressDidChangeNotification;
        [Field("MBRouteControllerProgressDidChangeNotification")]
        NSString ProgressDidChangeNotification { get; }

        /// <summary>
        /// Posted after the user diverges from the expected route, just before `MBRouteController` attempts to calculate a new route.
        /// The user info dictionary contains the key `MBRouteControllerLocationKey`.
        /// </summary>
        /// extern const NSNotificationName MBRouteControllerWillRerouteNotification;
        [Field("MBRouteControllerWillRerouteNotification")]
        NSString WillRerouteNotification { get; }

        /// <summary>
        /// Posted when `MBRouteController` obtains a new route in response to the user diverging from a previous route.
        /// The user info dictionary contains the keys `MBRouteControllerLocationKey` and `MBRouteControllerIsProactiveKey`.
        /// </summary>
        /// extern const NSNotificationName MBRouteControllerDidRerouteNotification;
        [Field("MBRouteControllerDidRerouteNotification")]
        NSString DidRerouteNotification { get; }

        /// <summary>
        /// Posted when `MBRouteController` fails to reroute the user after the user diverges from the expected route.
        /// The user info dictionary contains the key `MBRouteControllerRoutingErrorKey`.
        /// </summary>
        /// extern const NSNotificationName MBRouteControllerDidFailToRerouteNotification;
        [Field("MBRouteControllerDidFailToRerouteNotification")]
        NSString DidFailToRerouteNotification { get; }

        /// <summary>
        /// Posted when `MBRouteController` detects that the user has passed an ideal point for saying an instruction aloud.
        /// The user info dictionary contains the key `MBRouteControllerRouteProgressKey`.
        /// </summary>
        /// extern const NSNotificationName MBRouteControllerDidPassSpokenInstructionPointNotification;
        [Field("MBRouteControllerDidPassSpokenInstructionPointNotification")]
        NSString DidPassSpokenInstructionPointNotification { get; }

        /// <summary>
        /// A key in the user info dictionary of a `Notification.Name.MBRouteControllerProgressDidChange` or `Notification.Name.RouteControllerDidPassSpokenInstructionPoint` notification. The corresponding value is a `RouteProgress` object representing the current route progress.
        /// </summary>
        /// extern const MBRouteControllerNotificationUserInfoKey MBRouteControllerRouteProgressKey;
        [Field("MBRouteControllerRouteProgressKey")]
        NSString RouteProgressKey { get; }

        /// <summary>
        /// A key in the user info dictionary of a `Notification.Name.MBRouteControllerProgressDidChange` or `Notification.Name.RouteControllerWillReroute` notification. The corresponding value is a `CLLocation` object representing the current idealized user location.
        /// </summary>
        /// extern const MBRouteControllerNotificationUserInfoKey MBRouteControllerLocationKey;
        [Field("MBRouteControllerLocationKey")]
        NSString LocationKey { get; }

        /// <summary>
        /// A key in the user info dictionary of a `Notification.Name.MBRouteControllerProgressDidChange` or `Notification.Name.RouteControllerWillReroute` notification. The corresponding value is a `CLLocation` object representing the current raw user location.
        /// </summary>
        /// extern const MBRouteControllerNotificationUserInfoKey MBRouteControllerRawLocationKey;
        [Field("MBRouteControllerRawLocationKey")]
        NSString RawLocationKey { get; }

        /// <summary>
        /// A key in the user info dictionary of a `Notification.Name.RouteControllerDidFailToReroute` notification. The corresponding value is an `NSError` object indicating why `RouteController` was unable to calculate a new route.
        /// </summary>
        /// extern const MBRouteControllerNotificationUserInfoKey MBRouteControllerRoutingErrorKey;
        [Field("MBRouteControllerRoutingErrorKey")]
        NSString RoutingErrorKey { get; }

        /// <summary>
        /// A key in the user info dictionary of a `Notification.Name.RouteControllerDidReroute` notification. The corresponding value is an `NSNumber` instance containing a Boolean value indicating whether `RouteController` proactively rerouted the user onto a faster route.
        /// </summary>
        /// extern const MBRouteControllerNotificationUserInfoKey MBRouteControllerIsProactiveKey;
        [Field("MBRouteControllerIsProactiveKey")]
        NSString IsProactiveKey { get; }
    }

    [Static]
    partial interface MBNotificationKey {
        /// <summary>
        /// Constant representing the domain in which errors created in this library will live under.
        /// </summary>
        /// extern NSString *const MBErrorDomain;
        [Field("MBErrorDomain")]
        NSString ErrorDomain { get; }
    }

    // @interface MBDistanceFormatter : NSLengthFormatter
    [BaseType (typeof(NSLengthFormatter))]
    [DisableDefaultCtor]
    interface MBDistanceFormatter
    {
        /// -(instancetype _Nonnull)initWithApproximate:(BOOL)approximate __attribute__((objc_designated_initializer));
        [Export ("initWithApproximate:")]
        [DesignatedInitializer]
        IntPtr Constructor (bool approximate);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export ("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor (NSCoder decoder);

        /// -(NSString * _Nonnull)stringFrom:(CLLocationDistance)distance __attribute__((warn_unused_result));
        [Export ("stringFrom:")]
        string StringFrom (double distance);

        /// -(NSString * _Nonnull)stringFromMeters:(double)numberInMeters __attribute__((warn_unused_result));
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
        /// -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(id)profileIdentifier __attribute__((objc_designated_initializer));
        [Export ("initWithWaypoints:profileIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBWaypoint[] waypoints, NSObject profileIdentifier);

        /// -(instancetype _Nonnull)initWithLocations:(NSArray<CLLocation *> * _Nonnull)locations profileIdentifier:(id)profileIdentifier;
        [Export ("initWithLocations:profileIdentifier:")]
        IntPtr Constructor (CLLocation[] locations, NSObject profileIdentifier);

        /// -(instancetype _Nonnull)initWithCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates profileIdentifier:(id)profileIdentifier;
        [Export ("initWithCoordinates:profileIdentifier:")]
        IntPtr Constructor (NSValue[] coordinates, NSObject profileIdentifier);
    }

// @interface MBNavigationSettings : NSObject
    [BaseType(typeof(NSObject))]
    interface MBNavigationSettings
    {
        /// /// The volume that the voice controller will use.
        /// /// This volume is relative to the system’s volume where 1.0 is same volume as the system.
        /// @property (nonatomic) float voiceVolume;
        [Export ("voiceVolume")]
        float VoiceVolume { get; set; }
        /// /// Indicates whether the voice controller should be muted or not.
        /// @property (nonatomic) BOOL voiceMuted;
        [Export ("voiceMuted")]
        bool VoiceMuted { get; set; }

        /// - (nonnull instancetype)init SWIFT_UNAVAILABLE;
        /// - (void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey, id> * _Nullable)change context:(void * _Nullable)context;
        [Export ("observeValueForKeyPath:ofObject:change:context:")]
        void ObserveValueForKeyPath (NSString keyPath, NSObject owner, NSDictionary change, [NullAllowed]NSObject context);
    }

    // @interface MBReplayLocationManager : MBNavigationLocationManager
    [BaseType (typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBReplayLocationManager
    {
        /// @property (nonatomic) NSTimeInterval speedMultiplier;
        [Export ("speedMultiplier")]
        double SpeedMultiplier { get; set; }

        /// @property (copy, nonatomic) NSArray<CLLocation *> * _Null_unspecified locations;
        [Export ("locations", ArgumentSemantic.Copy)]
        CLLocation[] Locations { get; set; }

        /// @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        /// -(void)startUpdatingLocation;
        [Export ("startUpdatingLocation")]
        void StartUpdatingLocation ();

        /// -(void)stopUpdatingLocation;
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

        /// @property (nonatomic, weak) id<MBRouteControllerDelegate> _Nullable delegate;
        [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        /// @property (nonatomic, strong) MBDirections * _Nonnull directions;
        [Export ("directions", ArgumentSemantic.Strong)]
        MBDirections Directions { get; set; }

        /// @property (nonatomic, strong) MBNavigationLocationManager * _Null_unspecified locationManager;
        [Export ("locationManager", ArgumentSemantic.Strong)]
        MBNavigationLocationManager NavigationLocationManager { get; set; }

        /// @property (nonatomic) BOOL isDeadReckoningEnabled;
        [Export ("isDeadReckoningEnabled")]
        bool IsDeadReckoningEnabled { get; set; }

        /// @property (nonatomic) BOOL reroutesOpportunistically;
        [Export ("reroutesOpportunistically")]
        bool ReroutesOpportunistically { get; set; }

        /// -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route directions:(MBDirections * _Nonnull)directions locationManager:(MBNavigationLocationManager * _Nonnull)locationManager __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:directions:locationManager:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route, MBDirections directions, MBNavigationLocationManager locationManager);

        /// -(void)resume;
        [Export ("resume")]
        void Resume ();

        /// -(void)suspendLocationUpdates;
        [Export ("suspendLocationUpdates")]
        void SuspendLocationUpdates ();

        /// @property (readonly, nonatomic) CLLocationDistance reroutingTolerance;
        [Export ("reroutingTolerance")]
        double ReroutingTolerance { get; }

        /// @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        /// -(NSString * _Nonnull)recordFeedbackWithType:(enum MBFeedbackType)type description:(NSString * _Nullable)description __attribute__((warn_unused_result));
        [Export ("recordFeedbackWithType:description:")]
        string RecordFeedbackWithType (MBFeedbackType type, [NullAllowed] string description);

        /// -(void)updateFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId type:(enum MBFeedbackType)type source:(enum MBFeedbackSource)source description:(NSString * _Nullable)description;
        [Export ("updateFeedbackWithFeedbackId:type:source:description:")]
        void UpdateFeedbackWithFeedbackId (string feedbackId, MBFeedbackType type, MBFeedbackSource source, [NullAllowed] string description);

        /// -(void)cancelFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId;
        [Export ("cancelFeedbackWithFeedbackId:")]
        void CancelFeedbackWithFeedbackId (string feedbackId);
    }

    // @interface MapboxCoreNavigation_Swift_362 (MBRouteController) <CLLocationManagerDelegate>
    partial interface MBRouteController : ICLLocationManagerDelegate
    {
        /// -(void)locationManager:(CLLocationManager * _Nonnull)manager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export ("locationManager:didUpdateLocations:")]
        void LocationManager (CLLocationManager manager, CLLocation[] locations);

        /// -(BOOL)userIsOnRoute:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export ("userIsOnRoute:")]
        bool UserIsOnRoute (CLLocation location);
    }

    // @protocol MBRouteControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MBRouteControllerDelegate
    {
        /// @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export ("routeController:shouldRerouteFromLocation:")]
        bool RouteController_shouldRerouteFromLocation (MBRouteController routeController, CLLocation location);

        /// @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export ("routeController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool RouteController_shouldIncrementLegWhenArrivingAtWaypoint (MBRouteController routeController, MBWaypoint waypoint);

        /// @optional -(void)routeController:(MBRouteController * _Nonnull)routeController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export ("routeController:willRerouteFromLocation:")]
        void RouteController_willRerouteFromLocation (MBRouteController routeController, CLLocation location);

        /// @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didDiscardLocation:(CLLocation * _Nonnull)location;
        [Export ("routeController:didDiscardLocation:")]
        void RouteController_didDiscardLocation (MBRouteController routeController, CLLocation location);

        /// @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export ("routeController:didRerouteAlongRoute:")]
        void RouteController_didRerouteAlongRoute (MBRouteController routeController, MBRoute route);

        /// @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export ("routeController:didFailToRerouteWithError:")]
        void RouteController_didFailToRerouteWithError (MBRouteController routeController, NSError error);

        /// @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export ("routeController:didUpdateLocations:")]
        void RouteController_didUpdateLocations (MBRouteController routeController, CLLocation[] locations);

        /// Called when the route controller arrives at a waypoint.
        /// \param waypoint The waypoint that the controller has arrived at.
        ///
        /// \param finalDestination A boolean flag that signals that the waypoint is the final destination.
        ///
        /// - (void)routeController:(MBRouteController * _Nonnull)routeController didArriveAtWaypoint:(MBWaypoint * _Nonnull)waypoint;
        [Export ("routeController:didArriveAtWaypoint:")]
        void RouteController_didArriveAtWaypoint (MBRouteController routeController, MBWaypoint waypoint);
    }

    // @interface MBRouteLegProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteLegProgress
    {
        /// @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull leg;
        [Export ("leg", ArgumentSemantic.Strong)]
        MBRouteLeg Leg { get; }

        /// @property (nonatomic) NSInteger stepIndex;
        [Export ("stepIndex")]
        nint StepIndex { get; set; }

        /// @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; }

        /// @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        /// @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        /// @property (nonatomic) BOOL userHasArrivedAtWaypoint;
        [Export ("userHasArrivedAtWaypoint")]
        bool UserHasArrivedAtWaypoint { get; set; }

        /// -(MBRouteStep * _Nullable)stepBefore:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("stepBefore:")]
        [return: NullAllowed]
        MBRouteStep StepBefore (MBRouteStep step);

        /// -(MBRouteStep * _Nullable)stepAfter:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("stepAfter:")]
        [return: NullAllowed]
        MBRouteStep StepAfter (MBRouteStep step);

        /// @property (readonly, nonatomic, strong) MBRouteStep * _Nullable priorStep;
        [NullAllowed, Export ("priorStep", ArgumentSemantic.Strong)]
        MBRouteStep PriorStep { get; }

        /// @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull currentStep;
        [Export ("currentStep", ArgumentSemantic.Strong)]
        MBRouteStep CurrentStep { get; }

        /// @property (readonly, nonatomic, strong) MBRouteStep * _Nullable upComingStep;
        [NullAllowed, Export ("upComingStep", ArgumentSemantic.Strong)]
        MBRouteStep UpComingStep { get; }

        /// @property (readonly, nonatomic, strong) MBRouteStep * _Nullable followOnStep;
        [NullAllowed, Export ("followOnStep", ArgumentSemantic.Strong)]
        MBRouteStep FollowOnStep { get; }

        /// -(BOOL)isCurrentStep:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export ("isCurrentStep:")]
        bool IsCurrentStep (MBRouteStep step);

        /// @property (nonatomic, strong) MBRouteStepProgress * _Nonnull currentStepProgress;
        [Export ("currentStepProgress", ArgumentSemantic.Strong)]
        MBRouteStepProgress CurrentStepProgress { get; set; }

        /// -(instancetype _Nonnull)initWithLeg:(MBRouteLeg * _Nonnull)leg stepIndex:(NSInteger)stepIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithLeg:stepIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRouteLeg leg, nint stepIndex, nint spokenInstructionIndex);

        /// @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nonnull nearbyCoordinates;
        [Export ("nearbyCoordinates", ArgumentSemantic.Copy)]
        NSValue[] NearbyCoordinates { get; }
    }

    // @interface MBRouteProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteProgress
    {
        /// @property (readonly, nonatomic, strong) MBRoute * _Nonnull route;
        [Export ("route", ArgumentSemantic.Strong)]
        MBRoute Route { get; }

        /// @property (nonatomic) NSInteger legIndex;
        [Export ("legIndex")]
        nint LegIndex { get; set; }

        /// @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull currentLeg;
        [Export ("currentLeg", ArgumentSemantic.Strong)]
        MBRouteLeg CurrentLeg { get; }

        /// @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; }

        /// @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        /// @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        /// @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export ("distanceRemaining")]
        double DistanceRemaining { get; }

        /// @property (readonly, copy, nonatomic) NSArray<MBWaypoint *> * _Nonnull remainingWaypoints;
        [Export ("remainingWaypoints", ArgumentSemantic.Copy)]
        MBWaypoint[] RemainingWaypoints { get; }

        /// @property (nonatomic, strong) MBRouteLegProgress * _Null_unspecified currentLegProgress;
        [Export ("currentLegProgress", ArgumentSemantic.Strong)]
        MBRouteLegProgress CurrentLegProgress { get; set; }

        /// -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route legIndex:(NSInteger)legIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:legIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route, nint legIndex, nint spokenInstructionIndex);
    }

    // @interface MBRouteStepProgress : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteStepProgress
    {
        /// @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull step;
        [Export ("step", ArgumentSemantic.Strong)]
        MBRouteStep Step { get; }

        /// @property (nonatomic) CLLocationDistance distanceTraveled;
        [Export ("distanceTraveled")]
        double DistanceTraveled { get; set; }

        /// @property (nonatomic) CLLocationDistance userDistanceToManeuverLocation;
        [Export ("userDistanceToManeuverLocation")]
        double UserDistanceToManeuverLocation { get; set; }

        /// @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export ("distanceRemaining")]
        double DistanceRemaining { get; }

        /// @property (readonly, nonatomic) double fractionTraveled;
        [Export ("fractionTraveled")]
        double FractionTraveled { get; }

        /// @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export ("durationRemaining")]
        double DurationRemaining { get; }

        /// -(instancetype _Nonnull)initWithStep:(MBRouteStep * _Nonnull)step spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export ("initWithStep:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRouteStep step, nint spokenInstructionIndex);

        /// @property (copy, nonatomic) NSArray<MBIntersection *> * _Nullable intersectionsIncludingUpcomingManeuverIntersection;
        [NullAllowed, Export ("intersectionsIncludingUpcomingManeuverIntersection", ArgumentSemantic.Copy)]
        MBIntersection[] IntersectionsIncludingUpcomingManeuverIntersection { get; set; }

        /// @property (readonly, nonatomic, strong) MBIntersection * _Nullable upcomingIntersection;
        [NullAllowed, Export ("upcomingIntersection", ArgumentSemantic.Strong)]
        MBIntersection UpcomingIntersection { get; }

        /// @property (nonatomic) NSInteger intersectionIndex;
        [Export ("intersectionIndex")]
        nint IntersectionIndex { get; set; }

        /// @property (nonatomic) NSInteger spokenInstructionIndex;
        [Export ("spokenInstructionIndex")]
        nint SpokenInstructionIndex { get; set; }

        /// @property (readonly, nonatomic, strong) MBSpokenInstruction * _Nullable currentSpokenInstruction;
        [NullAllowed, Export ("currentSpokenInstruction", ArgumentSemantic.Strong)]
        MBSpokenInstruction CurrentSpokenInstruction { get; }
    }

    // @interface MBSimulatedLocationManager : MBNavigationLocationManager
    [BaseType (typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBSimulatedLocationManager
    {
        /// @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export ("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        /// @property (nonatomic) double speedMultiplier;
        [Export ("speedMultiplier", ArgumentSemantic.Assign)]
        double SpeedMultiplier { get; set; }

        /// -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route __attribute__((objc_designated_initializer));
        [Export ("initWithRoute:")]
        [DesignatedInitializer]
        IntPtr Constructor (MBRoute route);

        /// -(void)startUpdatingLocation;
        [Export ("startUpdatingLocation")]
        void StartUpdatingLocation ();

        /// -(void)stopUpdatingLocation;
        [Export ("stopUpdatingLocation")]
        void StopUpdatingLocation ();
    }
}
