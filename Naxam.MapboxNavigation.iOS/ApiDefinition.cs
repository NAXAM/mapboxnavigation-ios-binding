using System;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using Mapbox;
using MapboxCoreNavigation;
using MapboxDirections;
using ObjCRuntime;
using UIKit;

namespace MapboxNavigation
{
    // @interface MGLNavigationAdditions
    [Category]
    [BaseType(typeof(MGLMapView))]
    interface MGLNavigationAdditions
    {
        // -(void)mapViewDidFinishRenderingFrameFullyRendered:(id)fullyRendered;
        [Export("mapViewDidFinishRenderingFrameFullyRendered:")]
        void MapViewDidFinishRenderingFrameFullyRendered(NSObject fullyRendered);

        // @property (readonly, nonatomic) int * _Nullable displayLink;
        [NullAllowed, Export("displayLink")]
        CADisplayLink DisplayLink();
    }

    // @interface MBStylableLabel : UILabel
    [BaseType(typeof(UILabel))]
    interface MBStylableLabel
    {
        // @property (nonatomic, strong) UIColor * _Nonnull normalTextColor;
        [Export("normalTextColor", ArgumentSemantic.Strong)]
        UIColor NormalTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull normalFont;
        [Export("normalFont", ArgumentSemantic.Strong)]
        UIFont NormalFont { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBArrivalTimeLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBArrivalTimeLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface BaseInstructionsBannerView : UIControl
    [BaseType(typeof(UIControl), Name = "_TtC16MapboxNavigation26BaseInstructionsBannerView")]
    interface BaseInstructionsBannerView
    {

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();
    }

    // @interface MBBottomBannerContentView : UIView
    [BaseType(typeof(UIView))]
    interface MBBottomBannerContentView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBBottomBannerView : UIView
    [BaseType(typeof(UIView))]
    interface MBBottomBannerView
    {

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();
    }

    // @interface MapboxNavigation_Swift_247 (MBBottomBannerView)
    [Category]
    [BaseType(typeof(MBBottomBannerView))]
    interface MBBottomBannerView_MapboxNavigation_Swift_247
    {
        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
    }

    // @interface MBStylableButton : UIButton
    [BaseType(typeof(UIButton))]
    interface MBStylableButton
    {
        // @property (nonatomic, strong) UIFont * _Nonnull textFont;
        [Export("textFont", ArgumentSemantic.Strong)]
        UIFont TextFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBButton : MBStylableButton
    [BaseType(typeof(MBStylableButton))]
    interface MBButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBCancelButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBCancelButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBLineView : UIView
    [BaseType(typeof(UIView))]
    interface MBLineView
    {
        // @property (nonatomic, strong) UIColor * _Nonnull lineColor;
        [Export("lineColor", ArgumentSemantic.Strong)]
        UIColor LineColor { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBDashedLineView : MBLineView
    [BaseType(typeof(MBLineView))]
    interface MBDashedLineView
    {
        // @property (nonatomic) CGFloat dashedLength;
        [Export("dashedLength")]
        nfloat DashedLength { get; set; }

        // @property (nonatomic) CGFloat dashedGap;
        [Export("dashedGap")]
        nfloat DashedGap { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface MBStyle
    {
        // @property (nonatomic, strong) UIColor * _Nullable tintColor;
        [NullAllowed, Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable fontFamily;
        [NullAllowed, Export("fontFamily")]
        string FontFamily { get; set; }

        // @property (nonatomic) enum MBStyleType styleType;
        [Export("styleType", ArgumentSemantic.Assign)]
        MBStyleType StyleType { get; set; }

        // @property (copy, nonatomic) NSURL * _Nonnull mapStyleURL;
        [Export("mapStyleURL", ArgumentSemantic.Copy)]
        NSUrl MapStyleURL { get; set; }

        // -(void)apply;
        [Export("apply")]
        void Apply();
    }

    // @interface MBDayStyle : MBStyle
    [BaseType(typeof(MBStyle))]
    interface MBDayStyle
    {
        // -(void)apply;
        [Export("apply")]
        void Apply();
    }

    // @interface MBDismissButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBDismissButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBDistanceLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBDistanceLabel
    {
        // @property (nonatomic, strong) UIColor * _Nonnull valueTextColor;
        [Export("valueTextColor", ArgumentSemantic.Strong)]
        UIColor ValueTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull unitTextColor;
        [Export("unitTextColor", ArgumentSemantic.Strong)]
        UIColor UnitTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull valueFont;
        [Export("valueFont", ArgumentSemantic.Strong)]
        UIFont ValueFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull unitFont;
        [Export("unitFont", ArgumentSemantic.Strong)]
        UIFont UnitFont { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBDistanceRemainingLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBDistanceRemainingLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBFloatingButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBFloatingButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBHighlightedButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBHighlightedButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBInstructionLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBInstructionLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBInstructionsBannerContentView : UIView
    [BaseType(typeof(UIView))]
    interface MBInstructionsBannerContentView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBInstructionsBannerView : BaseInstructionsBannerView
    [BaseType(typeof(BaseInstructionsBannerView))]
    interface MBInstructionsBannerView
    {
    }

    // @interface MBLaneView : UIView
    [BaseType(typeof(UIView))]
    interface MBLaneView
    {
        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; set; }

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBLanesView : UIView
    [BaseType(typeof(UIView))]
    interface MBLanesView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBLanesContainerView : MBLanesView
    [BaseType(typeof(MBLanesView))]
    interface MBLanesContainerView
    {
    }

    // @interface MBLanesStyleKit : NSObject
    [BaseType(typeof(NSObject))]
    interface MBLanesStyleKit
    {
        // +(void)drawLane_straight_rightWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
        [Static]
        [Export("drawLane_straight_rightWithPrimaryColor:")]
        void DrawLane_straight_rightWithPrimaryColor(UIColor primaryColor);

        // +(void)drawLane_straight_onlyWithPrimaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor;
        [Static]
        [Export("drawLane_straight_onlyWithPrimaryColor:secondaryColor:")]
        void DrawLane_straight_onlyWithPrimaryColor(UIColor primaryColor, UIColor secondaryColor);

        // +(void)drawLane_right_hWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
        [Static]
        [Export("drawLane_right_hWithPrimaryColor:")]
        void DrawLane_right_hWithPrimaryColor(UIColor primaryColor);

        // +(void)drawLane_right_onlyWithPrimaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor;
        [Static]
        [Export("drawLane_right_onlyWithPrimaryColor:secondaryColor:")]
        void DrawLane_right_onlyWithPrimaryColor(UIColor primaryColor, UIColor secondaryColor);

        // +(void)drawLane_straightWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
        [Static]
        [Export("drawLane_straightWithPrimaryColor:")]
        void DrawLane_straightWithPrimaryColor(UIColor primaryColor);

        // +(void)drawLane_uturnWithPrimaryColor:(UIColor * _Nonnull)primaryColor;
        [Static]
        [Export("drawLane_uturnWithPrimaryColor:")]
        void DrawLane_uturnWithPrimaryColor(UIColor primaryColor);

        // +(void)drawLane_slight_rightWithPrimaryColor:(UIColor * _Nonnull)primaryColor scale:(CGFloat)scale;
        [Static]
        [Export("drawLane_slight_rightWithPrimaryColor:scale:")]
        void DrawLane_slight_rightWithPrimaryColor(UIColor primaryColor, nfloat scale);
    }

    // @interface MBManeuverContainerView : UIView
    [BaseType(typeof(UIView))]
    interface MBManeuverContainerView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBManeuverView : UIView
    [BaseType(typeof(UIView))]
    interface MBManeuverView
    {
        // @property (nonatomic, strong) UIColor * _Nonnull primaryColor;
        [Export("primaryColor", ArgumentSemantic.Strong)]
        UIColor PrimaryColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondaryColor;
        [Export("secondaryColor", ArgumentSemantic.Strong)]
        UIColor SecondaryColor { get; set; }

        // @property (nonatomic, strong) MBRouteStep * _Nullable step;
        [NullAllowed, Export("step", ArgumentSemantic.Strong)]
        MBRouteStep Step { get; set; }

        // @property (nonatomic) BOOL isStart;
        [Export("isStart")]
        bool IsStart { get; set; }

        // @property (nonatomic) BOOL isEnd;
        [Export("isEnd")]
        bool IsEnd { get; set; }

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBManeuversStyleKit : NSObject
    [BaseType(typeof(NSObject))]
    interface MBManeuversStyleKit
    {
        // +(void)drawArrow180rightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArrow180rightWithFrame:resizing:primaryColor:size:")]
        void DrawArrow180rightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawArrowrightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArrowrightWithFrame:resizing:primaryColor:size:")]
        void DrawArrowrightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawArrowslightrightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArrowslightrightWithFrame:resizing:primaryColor:size:")]
        void DrawArrowslightrightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawArrowstraightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArrowstraightWithFrame:resizing:primaryColor:size:")]
        void DrawArrowstraightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawArrowsharprightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArrowsharprightWithFrame:resizing:primaryColor:size:")]
        void DrawArrowsharprightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawArriveWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArriveWithFrame:resizing:primaryColor:size:")]
        void DrawArriveWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawStartingWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawStartingWithFrame:resizing:primaryColor:size:")]
        void DrawStartingWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawDestinationWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawDestinationWithFrame:resizing:primaryColor:size:")]
        void DrawDestinationWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawMergeWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor size:(CGSize)size;
        [Static]
        [Export("drawMergeWithFrame:resizing:primaryColor:secondaryColor:size:")]
        void DrawMergeWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, UIColor secondaryColor, CGSize size);

        // +(void)drawForkWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor size:(CGSize)size;
        [Static]
        [Export("drawForkWithFrame:resizing:primaryColor:secondaryColor:size:")]
        void DrawForkWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, UIColor secondaryColor, CGSize size);

        // +(void)drawOfframpWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor size:(CGSize)size;
        [Static]
        [Export("drawOfframpWithFrame:resizing:primaryColor:secondaryColor:size:")]
        void DrawOfframpWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, UIColor secondaryColor, CGSize size);

        // +(void)drawArriverightWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArriverightWithFrame:resizing:primaryColor:size:")]
        void DrawArriverightWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);

        // +(void)drawRoundaboutWithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor secondaryColor:(UIColor * _Nonnull)secondaryColor size:(CGSize)size roundabout_angle:(CGFloat)roundabout_angle roundabout_radius:(CGFloat)roundabout_radius;
        [Static]
        [Export("drawRoundaboutWithFrame:resizing:primaryColor:secondaryColor:size:roundabout_angle:roundabout_radius:")]
        void DrawRoundaboutWithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, UIColor secondaryColor, CGSize size, nfloat roundabout_angle, nfloat roundabout_radius);

        // +(void)drawArriveright2WithFrame:(CGRect)targetFrame resizing:(enum ManeuversStyleKitResizingBehavior)resizing primaryColor:(UIColor * _Nonnull)primaryColor size:(CGSize)size;
        [Static]
        [Export("drawArriveright2WithFrame:resizing:primaryColor:size:")]
        void DrawArriveright2WithFrame(CGRect targetFrame, ManeuversStyleKitResizingBehavior resizing, UIColor primaryColor, CGSize size);
    }

    // @interface MBMarkerView : UIView
    [BaseType(typeof(UIView))]
    interface MBMarkerView
    {
        // @property (nonatomic, strong) UIColor * _Nonnull innerColor;
        [Export("innerColor", ArgumentSemantic.Strong)]
        UIColor InnerColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull pinColor;
        [Export("pinColor", ArgumentSemantic.Strong)]
        UIColor PinColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull strokeColor;
        [Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBNavigationMapView <UIGestureRecognizerDelegate>
    [BaseType(typeof(MGLMapView))]
    interface MBNavigationMapView : IUIGestureRecognizerDelegate
    {
        // @property (readonly, nonatomic, class) CLLocationDistance defaultAltitude;
        [Static]
        [Export("defaultAltitude")]
        double DefaultAltitude { get; }

        // @property (readonly, nonatomic, class) CLLocationDistance zoomedOutMotorwayAltitude;
        [Static]
        [Export("zoomedOutMotorwayAltitude")]
        double ZoomedOutMotorwayAltitude { get; }

        // @property (readonly, nonatomic, class) CLLocationDistance longManeuverDistance;
        [Static]
        [Export("longManeuverDistance")]
        double LongManeuverDistance { get; }

        // @property (nonatomic) CGFloat tapGestureDistanceThreshold;
        [Export("tapGestureDistanceThreshold")]
        nfloat TapGestureDistanceThreshold { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficUnknownColor;
        [Export("trafficUnknownColor", ArgumentSemantic.Strong)]
        UIColor TrafficUnknownColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficLowColor;
        [Export("trafficLowColor", ArgumentSemantic.Strong)]
        UIColor TrafficLowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficModerateColor;
        [Export("trafficModerateColor", ArgumentSemantic.Strong)]
        UIColor TrafficModerateColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficHeavyColor;
        [Export("trafficHeavyColor", ArgumentSemantic.Strong)]
        UIColor TrafficHeavyColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficSevereColor;
        [Export("trafficSevereColor", ArgumentSemantic.Strong)]
        UIColor TrafficSevereColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull routeCasingColor;
        [Export("routeCasingColor", ArgumentSemantic.Strong)]
        UIColor RouteCasingColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull routeAlternateColor;
        [Export("routeAlternateColor", ArgumentSemantic.Strong)]
        UIColor RouteAlternateColor { get; set; }

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame styleURL:(NSURL * _Nullable)styleURL __attribute__((objc_designated_initializer));
        [Export("initWithFrame:styleURL:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, [NullAllowed] NSUrl styleURL);

        // -(CGPoint)anchorPointForGesture:(UIGestureRecognizer * _Nonnull)gesture __attribute__((warn_unused_result));
        [Export("anchorPointForGesture:")]
        CGPoint AnchorPointForGesture(UIGestureRecognizer gesture);

        // @property (nonatomic) BOOL showsUserLocation;
        [Export("showsUserLocation")]
        bool ShowsUserLocation { get; set; }

        // -(void)updateCourseTrackingWithLocation:(CLLocation * _Nullable)location animated:(BOOL)animated;
        [Export("updateCourseTrackingWithLocation:animated:")]
        void UpdateCourseTrackingWithLocation([NullAllowed] CLLocation location, bool animated);

        // -(void)mapViewDidFinishRenderingFrameFullyRendered:(BOOL)fullyRendered;
        [Export("mapViewDidFinishRenderingFrameFullyRendered:")]
        void MapViewDidFinishRenderingFrameFullyRendered(bool fullyRendered);

        // @property (nonatomic, strong) UIView * _Nullable userCourseView;
        [NullAllowed, Export("userCourseView", ArgumentSemantic.Strong)]
        UIView UserCourseView { get; set; }

        // -(void)showRoutes:(NSArray<MBRoute *> * _Nonnull)routes legIndex:(NSInteger)legIndex;
        [Export("showRoutes:legIndex:")]
        void ShowRoutes(MBRoute[] routes, nint legIndex);

        // -(void)removeRoutes;
        [Export("removeRoutes")]
        void RemoveRoutes();

        // -(void)showWaypoints:(MBRoute * _Nonnull)route legIndex:(NSInteger)legIndex;
        [Export("showWaypoints:legIndex:")]
        void ShowWaypoints(MBRoute route, nint legIndex);

        // -(void)removeWaypoints;
        [Export("removeWaypoints")]
        void RemoveWaypoints();

        // -(void)addArrowWithRoute:(MBRoute * _Nonnull)route legIndex:(NSInteger)legIndex stepIndex:(NSInteger)stepIndex;
        [Export("addArrowWithRoute:legIndex:stepIndex:")]
        void AddArrowWithRoute(MBRoute route, nint legIndex, nint stepIndex);

        // -(void)removeArrow;
        [Export("removeArrow")]
        void RemoveArrow();

        // -(void)showVoiceInstructionsOnMapWithRoute:(MBRoute * _Nonnull)route;
        [Export("showVoiceInstructionsOnMapWithRoute:")]
        void ShowVoiceInstructionsOnMapWithRoute(MBRoute route);
    }

    // @protocol MBNavigationMapViewDelegate
    [Protocol, Model]
    interface MBNavigationMapViewDelegate
    {
        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer RouteStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer WaypointStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointSymbolStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointSymbolStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer WaypointSymbolStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeCasingStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeCasingStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer RouteCasingStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didSelectRoute:(MBRoute * _Nonnull)route;
        [Export("navigationMapView:didSelectRoute:")]
        void DidSelectRoute(MBNavigationMapView mapView, MBRoute route);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didSelectWaypoint:(MBWaypoint * _Nonnull)waypoint;
        [Export("navigationMapView:didSelectWaypoint:")]
        void DidSelectWaypoint(MBNavigationMapView mapView, MBWaypoint waypoint);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribingRoute:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribingRoute:")]
        [return: NullAllowed]
        MGLShape ShapeDescribingRoute(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView simplifiedShapeDescribingRoute:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:simplifiedShapeDescribingRoute:")]
        [return: NullAllowed]
        MGLShape SimplifiedShapeDescribingRoute(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribingWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribingWaypoints:")]
        [return: NullAllowed]
        MGLShape ShapeDescribingWaypoints(MBNavigationMapView mapView, MBWaypoint[] waypoints);

        // @optional -(CGPoint)navigationMapViewUserAnchorPoint:(MBNavigationMapView * _Nonnull)mapView __attribute__((warn_unused_result));
        [Export("navigationMapViewUserAnchorPoint:")]
        CGPoint NavigationMapViewUserAnchorPoint(MBNavigationMapView mapView);
    }

    // @interface MBNavigationViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MBNavigationViewController
    {
        // @property (nonatomic, strong) MBRoute * _Null_unspecified route;
        [Export("route", ArgumentSemantic.Strong)]
        MBRoute Route { get; set; }

        // @property (nonatomic, strong) id<MGLAnnotation> _Null_unspecified destination;
        [Export("destination", ArgumentSemantic.Strong)]
        MGLAnnotation Destination { get; set; }

        // @property (nonatomic, strong) MBDirections * _Null_unspecified directions;
        [Export("directions", ArgumentSemantic.Strong)]
        MBDirections Directions { get; set; }

        // @property (nonatomic, strong) MGLMapCamera * _Nullable pendingCamera;
        [NullAllowed, Export("pendingCamera", ArgumentSemantic.Strong)]
        MGLMapCamera PendingCamera { get; set; }

        // @property (nonatomic, strong) id<MGLAnnotation> _Nullable origin;
        [NullAllowed, Export("origin", ArgumentSemantic.Strong)]
        MGLAnnotation Origin { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MBNavigationViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MBNavigationViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) MBRouteVoiceController * _Nullable voiceController;
        [NullAllowed, Export("voiceController", ArgumentSemantic.Strong)]
        MBRouteVoiceController VoiceController { get; set; }

        // @property (nonatomic, strong) MBRouteController * _Null_unspecified routeController;
        [Export("routeController", ArgumentSemantic.Strong)]
        MBRouteController RouteController { get; set; }

        // @property (copy, nonatomic) NSArray<MBStyle *> * _Nullable styles;
        [NullAllowed, Export("styles", ArgumentSemantic.Copy)]
        MBStyle[] Styles { get; set; }

        // @property (readonly, nonatomic, strong) MBNavigationMapView * _Nullable mapView;
        [NullAllowed, Export("mapView", ArgumentSemantic.Strong)]
        MBNavigationMapView MapView { get; }

        // @property (nonatomic) BOOL snapsUserLocationAnnotationToRoute;
        [Export("snapsUserLocationAnnotationToRoute")]
        bool SnapsUserLocationAnnotationToRoute { get; set; }

        // @property (nonatomic) BOOL sendsNotifications;
        [Export("sendsNotifications")]
        bool SendsNotifications { get; set; }

        // @property (nonatomic) BOOL showsReportFeedback;
        [Export("showsReportFeedback")]
        bool ShowsReportFeedback { get; set; }

        // @property (nonatomic) BOOL automaticallyAdjustsStyleForTimeOfDay;
        [Export("automaticallyAdjustsStyleForTimeOfDay")]
        bool AutomaticallyAdjustsStyleForTimeOfDay { get; set; }

        // @property (nonatomic) BOOL annotatesSpokenInstructions;
        [Export("annotatesSpokenInstructions")]
        bool AnnotatesSpokenInstructions { get; set; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route directions:(MBDirections * _Nonnull)directions style:(NSArray<MBStyle *> * _Nullable)styles locationManager:(MBNavigationLocationManager * _Nullable)locationManager __attribute__((objc_designated_initializer));
        [Export("initWithRoute:directions:style:locationManager:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRoute route, MBDirections directions, [NullAllowed] MBStyle[] styles, [NullAllowed] MBNavigationLocationManager locationManager);
    }

    // @interface MapboxNavigation_Swift_660 (MBNavigationViewController)
    [Category]
    [BaseType(typeof(MBNavigationViewController))]
    interface MBNavigationViewController_MapboxNavigation_Swift_660
    {
        // -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("routeController:shouldRerouteFromLocation:")]
        bool RouteController_shouldRerouteFromLocation(MBRouteController routeController, CLLocation location);

        // -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export("routeController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool RouteController_shouldIncrementLegWhenArrivingAtWaypoint(MBRouteController routeController, MBWaypoint waypoint);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:willRerouteFromLocation:")]
        void RouteController_willRerouteFromLocation(MBRouteController routeController, CLLocation location);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export("routeController:didRerouteAlongRoute:")]
        void RouteController_didRerouteAlongRoute(MBRouteController routeController, MBRoute route);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export("routeController:didFailToRerouteWithError:")]
        void RouteController_didFailToRerouteWithError(MBRouteController routeController, NSError error);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export("routeController:didUpdateLocations:")]
        void RouteController_didUpdateLocations(MBRouteController routeController, CLLocation[] locations);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didDiscardLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:didDiscardLocation:")]
        void RouteController_didDiscardLocation(MBRouteController routeController, CLLocation location);
    }

    // @protocol MBNavigationViewControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MBNavigationViewControllerDelegate
    {
        // @optional -(void)navigationViewControllerDidCancelNavigation:(MBNavigationViewController * _Nonnull)navigationViewController;
        [Export("navigationViewControllerDidCancelNavigation:")]
        void NavigationViewControllerDidCancelNavigation(MBNavigationViewController navigationViewController);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didArriveAt:(MBWaypoint * _Nonnull)waypoint;
        [Export("navigationViewController:didArriveAt:")]
        void NavigationViewController_didArriveAt(MBNavigationViewController navigationViewController, MBWaypoint waypoint);

        // @optional -(BOOL)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("navigationViewController:shouldRerouteFromLocation:")]
        bool NavigationViewController_shouldRerouteFromLocation(MBNavigationViewController navigationViewController, CLLocation location);

        // @optional -(BOOL)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export("navigationViewController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool NavigationViewController_shouldIncrementLegWhenArrivingAtWaypoint(MBNavigationViewController navigationViewController, MBWaypoint waypoint);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export("navigationViewController:willRerouteFromLocation:")]
        void NavigationViewController_willRerouteFromLocation(MBNavigationViewController navigationViewController, CLLocation location);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export("navigationViewController:didRerouteAlongRoute:")]
        void NavigationViewController_didRerouteAlongRoute(MBNavigationViewController navigationViewController, MBRoute route);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export("navigationViewController:didFailToRerouteWithError:")]
        void NavigationViewController_didFailToRerouteWithError(MBNavigationViewController navigationViewController, NSError error);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer NavigationMapView_routeStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeCasingStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeCasingStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer NavigationMapView_routeCasingStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribing:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribing:")]
        [return: NullAllowed]
        MGLShape NavigationMapView_shapeDescribing(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView simplifiedShapeDescribing:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:simplifiedShapeDescribing:")]
        [return: NullAllowed]
        MGLShape NavigationMapView_simplifiedShapeDescribing(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer NavigationMapView_waypointStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointSymbolStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointSymbolStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer NavigationMapView_waypointSymbolStyleLayerWithIdentifier(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeFor:(NSArray<MBWaypoint *> * _Nonnull)waypoints __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeFor:")]
        [return: NullAllowed]
        MGLShape NavigationMapView_shapeFor(MBNavigationMapView mapView, MBWaypoint[] waypoints);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didTap:(MBRoute * _Nonnull)route;
        [Export("navigationMapView:didTap:")]
        void NavigationMapView_didTap(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLAnnotationImage * _Nullable)navigationMapView:(id)mapView imageFor:(id<MGLAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
        [Export("navigationMapView:imageFor:")]
        [return: NullAllowed]
        MGLAnnotationImage NavigationMapView_imageFor(NSObject mapView, MGLAnnotation annotation);

        // @optional -(MGLAnnotationView * _Nullable)navigationMapView:(id)mapView viewFor:(id<MGLAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
        [Export("navigationMapView:viewFor:")]
        [return: NullAllowed]
        MGLAnnotationView NavigationMapView_viewFor(NSObject mapView, MGLAnnotation annotation);

        // @optional -(void)navigationViewControllerDidOpenFeedback:(MBNavigationViewController * _Nonnull)viewController;
        [Export("navigationViewControllerDidOpenFeedback:")]
        void NavigationViewControllerDidOpenFeedback(MBNavigationViewController viewController);

        // @optional -(void)navigationViewControllerDidCancelFeedback:(MBNavigationViewController * _Nonnull)viewController;
        [Export("navigationViewControllerDidCancelFeedback:")]
        void NavigationViewControllerDidCancelFeedback(MBNavigationViewController viewController);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)viewController didSend:(NSString * _Nonnull)feedbackId feedbackType:(enum MBFeedbackType)feedbackType;
        [Export("navigationViewController:didSend:feedbackType:")]
        void NavigationViewController(MBNavigationViewController viewController, string feedbackId, MBFeedbackType feedbackType);

        // @optional -(CGPoint)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController mapViewUserAnchorPoint:(MBNavigationMapView * _Nonnull)mapView __attribute__((warn_unused_result));
        [Export("navigationViewController:mapViewUserAnchorPoint:")]
        CGPoint NavigationViewController(MBNavigationViewController navigationViewController, MBNavigationMapView mapView);
    }

    // @interface MBNextBannerView : UIView
    [BaseType(typeof(UIView))]
    interface MBNextBannerView
    {
        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();
    }

    // @interface MBNextInstructionLabel : MBInstructionLabel
    [BaseType(typeof(MBInstructionLabel))]
    interface MBNextInstructionLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBNightStyle : MBDayStyle
    [BaseType(typeof(MBDayStyle))]
    interface MBNightStyle
    {
        // -(void)apply;
        [Export("apply")]
        void Apply();
    }

    // @interface MBRouteVoiceController : NSObject <AVAudioPlayerDelegate, AVSpeechSynthesizerDelegate>
    [BaseType(typeof(NSObject))]
    interface MBRouteVoiceController : IAVAudioPlayerDelegate, IAVSpeechSynthesizerDelegate
    {
        // @property (nonatomic) BOOL isEnabled;
        [Export("isEnabled")]
        bool IsEnabled { get; set; }

        // @property (nonatomic) float volume;
        [Export("volume")]
        float Volume { get; set; }

        // @property (nonatomic) double instructionVoiceSpeedRate;
        [Export("instructionVoiceSpeedRate")]
        double InstructionVoiceSpeedRate { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull instructionVoiceVolume;
        [Export("instructionVoiceVolume")]
        string InstructionVoiceVolume { get; set; }

        // @property (nonatomic) BOOL playRerouteSound;
        [Export("playRerouteSound")]
        bool PlayRerouteSound { get; set; }

        // @property (nonatomic, strong) AVAudioPlayer * _Nonnull rerouteSoundPlayer;
        [Export("rerouteSoundPlayer", ArgumentSemantic.Strong)]
        AVAudioPlayer RerouteSoundPlayer { get; set; }

        // @property (nonatomic) NSTimeInterval bufferBetweenAnnouncements;
        [Export("bufferBetweenAnnouncements")]
        double BufferBetweenAnnouncements { get; set; }

        // -(void)audioPlayerDidFinishPlaying:(AVAudioPlayer * _Nonnull)player successfully:(BOOL)flag;
        [Export("audioPlayerDidFinishPlaying:successfully:")]
        void AudioPlayerDidFinishPlaying(AVAudioPlayer player, bool flag);

        // -(void)speechSynthesizer:(AVSpeechSynthesizer * _Nonnull)synthesizer didFinishSpeechUtterance:(AVSpeechUtterance * _Nonnull)utterance;
        [Export("speechSynthesizer:didFinishSpeechUtterance:")]
        void SpeechSynthesizer(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance);

        // -(void)didPassSpokenInstructionPointWithNotification:(NSNotification * _Nonnull)notification;
        [Export("didPassSpokenInstructionPointWithNotification:")]
        void DidPassSpokenInstructionPointWithNotification(NSNotification notification);
    }

    // @interface MBPollyVoiceController : MBRouteVoiceController
    [BaseType(typeof(MBRouteVoiceController))]
    [DisableDefaultCtor]
    interface MBPollyVoiceController
    {
        // @property (nonatomic) int globalVoiceId;
        [Export("globalVoiceId")]
        int GlobalVoiceId { get; set; }

        // @property (nonatomic) int regionType;
        [Export("regionType")]
        int RegionType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull identityPoolId;
        [Export("identityPoolId")]
        string IdentityPoolId { get; set; }

        // @property (nonatomic) NSTimeInterval timeoutIntervalForRequest;
        [Export("timeoutIntervalForRequest")]
        double TimeoutIntervalForRequest { get; set; }

        // @property (nonatomic) NSInteger stepsAheadToCache;
        [Export("stepsAheadToCache")]
        nint StepsAheadToCache { get; set; }

        // -(void)didPassSpokenInstructionPointWithNotification:(NSNotification * _Nonnull)notification;
        [Export("didPassSpokenInstructionPointWithNotification:")]
        void DidPassSpokenInstructionPointWithNotification(NSNotification notification);
    }

    // @interface MBPrimaryLabel : MBInstructionLabel
    [BaseType(typeof(MBInstructionLabel))]
    interface MBPrimaryLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

    }

    // @interface MBProgressBar : UIView
    [BaseType(typeof(UIView))]
    interface MBProgressBar
    {
        // @property (nonatomic, strong) UIColor * _Nonnull barColor;
        [Export("barColor", ArgumentSemantic.Strong)]
        UIColor BarColor { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBReportButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBReportButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBResumeButton : UIControl
    [BaseType(typeof(UIControl))]
    interface MBResumeButton
    {
        // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();
    }

    // @interface MBSecondaryLabel : MBInstructionLabel
    [BaseType(typeof(MBInstructionLabel))]
    interface MBSecondaryLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBSeparatorView : UIView
    [BaseType(typeof(UIView))]
    interface MBSeparatorView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBStatusView : UIView
    [BaseType(typeof(UIView))]
    interface MBStatusView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBStepInstructionsView : BaseInstructionsBannerView
    [BaseType(typeof(BaseInstructionsBannerView))]
    interface MBStepInstructionsView
    {
    }

    // @interface MBStepTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    interface MBStepTableViewCell
    {
    }

    // @interface MBStepsBackgroundView : UIView
    [BaseType(typeof(UIView))]
    interface MBStepsBackgroundView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBStepsViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    partial interface MBStepsViewController: IUITableViewDelegate,IUITableViewDataSource
    {
        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

    }

    //// @interface MapboxNavigation_Swift_920 (MBStepsViewController) <UITableViewDelegate>
    //partial interface MBStepsViewController : IUITableViewDelegate
    //{
    //    // -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    //    [Export("tableView:didSelectRowAtIndexPath:")]
    //    void RowSelected(UITableView tableView, NSIndexPath indexPath);
    //}

    //// @interface MapboxNavigation_Swift_925 (MBStepsViewController) <UITableViewDataSource>
    //partial interface MBStepsViewController : IUITableViewDataSource
    //{
    //    // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result));
    //    [Export("numberOfSectionsInTableView:")]
    //    nint NumberOfSections(UITableView tableView);

    //    // -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
    //    [Export("tableView:numberOfRowsInSection:")]
    //    nint RowsInSection(UITableView tableView, nint section);

    //    // -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export("tableView:heightForRowAtIndexPath:")]
    //    nfloat TableView(UITableView tableView, NSIndexPath indexPath);

    //    // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
    //    [Export("tableView:cellForRowAtIndexPath:")]
    //    UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath);

    //    // -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result));
    //    [Export("tableView:titleForHeaderInSection:")]
    //    [return: NullAllowed]
    //    string TitleForHeader(UITableView tableView, nint section);
    //}

    // @interface MBStyleKitMarker : NSObject
    [BaseType(typeof(NSObject))]
    interface MBStyleKitMarker
    {
        // +(void)drawMarkerWithFrame:(CGRect)frame innerColor:(UIColor * _Nonnull)innerColor shadowColor:(UIColor * _Nonnull)shadowColor pinColor:(UIColor * _Nonnull)pinColor strokeColor:(UIColor * _Nonnull)strokeColor;
        [Static]
        [Export("drawMarkerWithFrame:innerColor:shadowColor:pinColor:strokeColor:")]
        void DrawMarkerWithFrame(CGRect frame, UIColor innerColor, UIColor shadowColor, UIColor pinColor, UIColor strokeColor);
    }

    // @interface MBSubtitleLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBSubtitleLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBTimeRemainingLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBTimeRemainingLabel
    {
        // @property (nonatomic, strong) UIColor * _Nonnull trafficUnknownColor;
        [Export("trafficUnknownColor", ArgumentSemantic.Strong)]
        UIColor TrafficUnknownColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficLowColor;
        [Export("trafficLowColor", ArgumentSemantic.Strong)]
        UIColor TrafficLowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficModerateColor;
        [Export("trafficModerateColor", ArgumentSemantic.Strong)]
        UIColor TrafficModerateColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficHeavyColor;
        [Export("trafficHeavyColor", ArgumentSemantic.Strong)]
        UIColor TrafficHeavyColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull trafficSevereColor;
        [Export("trafficSevereColor", ArgumentSemantic.Strong)]
        UIColor TrafficSevereColor { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

    }

    // @interface MBTitleLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBTitleLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MapboxNavigation_Swift_987 (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_MapboxNavigation_Swift_987
    {
        // @property (readonly, nonatomic, strong) UIFont * _Nonnull adjustedFont;
        [Export("adjustedFont", ArgumentSemantic.Strong)]
        UIFont AdjustedFont();
    }

    // @protocol MBUserCourseView
    [Protocol, Model]
    interface MBUserCourseView
    {
        // @required -(void)updateWithLocation:(CLLocation * _Nonnull)location pitch:(CGFloat)pitch direction:(CLLocationDegrees)direction animated:(BOOL)animated tracksUserCourse:(BOOL)tracksUserCourse;
        [Abstract]
        [Export("updateWithLocation:pitch:direction:animated:tracksUserCourse:")]
        void Pitch(CLLocation location, nfloat pitch, double direction, bool animated, bool tracksUserCourse);
    }

    // @interface MBUserPuckCourseView : UIView <MBUserCourseView>
    [BaseType(typeof(UIView))]
    interface MBUserPuckCourseView : MBUserCourseView
    {
        // @property (nonatomic, strong) UIColor * _Nonnull puckColor;
        [Export("puckColor", ArgumentSemantic.Strong)]
        UIColor PuckColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillColor;
        [Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull shadowColor;
        [Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

    }

    // @protocol MBVoiceControllerDelegate
    [Protocol, Model]
    interface MBVoiceControllerDelegate
    {
        // @optional -(void)voiceController:(MBRouteVoiceController * _Nonnull)voiceController spokenInstrucionsDidFailWithError:(NSError * _Nonnull)error;
        [Export("voiceController:spokenInstrucionsDidFailWithError:")]
        void SpokenInstrucionsDidFailWithError(MBRouteVoiceController voiceController, NSError error);

        // @optional -(void)voiceController:(MBRouteVoiceController * _Nonnull)voiceController didInterruptSpokenInstruction:(MBSpokenInstruction * _Nonnull)interruptedInstruction withInstruction:(MBSpokenInstruction * _Nonnull)interruptingInstruction;
        [Export("voiceController:didInterruptSpokenInstruction:withInstruction:")]
        void DidInterruptSpokenInstruction(MBRouteVoiceController voiceController, MBSpokenInstruction interruptedInstruction, MBSpokenInstruction interruptingInstruction);
    }

    // @interface MBWayNameLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBWayNameLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MBWayNameView : UIView
    [BaseType(typeof(UIView))]
    interface MBWayNameView
    {
        // @property (nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }
}
