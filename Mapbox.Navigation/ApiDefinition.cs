using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreLocation;
using CoreGraphics;
using AVFoundation;
using Mapbox;
using Mapbox.Directions;

namespace Mapbox.Navigation
{
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBArrivalTimeLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBArrivalTimeLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface BaseInstructionsBannerView : UIControl
    [BaseType(typeof(UIControl), Name = "_TtC16MapboxNavigation26BaseInstructionsBannerView")]
    interface BaseInstructionsBannerView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)prepareForInterfaceBuilder;
        //[Export("prepareForInterfaceBuilder")]
        //void PrepareForInterfaceBuilder();
    }

    // @interface MBBottomBannerContentView : UIView
    [BaseType(typeof(UIView))]
    interface MBBottomBannerContentView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBBottomBannerView : UIView
    [BaseType(typeof(UIView))]
    interface MBBottomBannerView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

// @interface MBButton : MBStylableButton
    [BaseType(typeof(MBStylableButton))]
    interface MBButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBCancelButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBCancelButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBDistanceRemainingLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBDistanceRemainingLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBFloatingButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBFloatingButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBHighlightedButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBHighlightedButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }


    // @interface MBInstructionLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBInstructionLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBInstructionsBannerContentView : UIView
    [BaseType(typeof(UIView))]
    interface MBInstructionsBannerContentView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBInstructionsBannerView : BaseInstructionsBannerView
    [BaseType(typeof(BaseInstructionsBannerView))]
    interface MBInstructionsBannerView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBLanesView : UIView
    [BaseType(typeof(UIView))]
    interface MBLanesView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBLanesContainerView : MBLanesView
    [BaseType(typeof(MBLanesView))]
    interface MBLanesContainerView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

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

    partial interface IMBNavigationMapViewDelegate {}
    // @protocol MBNavigationMapViewDelegate
    [Protocol, Model]
    interface MBNavigationMapViewDelegate
    {
        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetRouteStyleLayerNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetWaypointStyleLayerNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointSymbolStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointSymbolStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetWaypointSymbolStyleLayerNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeCasingStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeCasingStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetRouteCasingStyleLayerInNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didSelectRoute:(MBRoute * _Nonnull)route;
        [Export("navigationMapView:didSelectRoute:")]
        void NavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didSelectWaypoint:(MBWaypoint * _Nonnull)waypoint;
        [Export("navigationMapView:didSelectWaypoint:")]
        void NavigationMapView(MBNavigationMapView mapView, MBWaypoint waypoint);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribingRoute:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribingRoute:")]
        [return: NullAllowed]
        MGLShape GetShapeDescribingRouteInNavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView simplifiedShapeDescribingRoute:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:simplifiedShapeDescribingRoute:")]
        [return: NullAllowed]
        MGLShape GetSimplifiedShapeDescribingRouteInNavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribingWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribingWaypoints:")]
        [return: NullAllowed]
        MGLShape GetShapeDescribingWaypointsInNavigationMapView(MBNavigationMapView mapView, MBWaypoint[] waypoints);

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
        IMBNavigationViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MBNavigationViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        IMBNavigationViewControllerDelegate WeakDelegate { get; set; }

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route directions:(MBDirections * _Nonnull)directions style:(NSArray<MBStyle *> * _Nullable)styles locationManager:(MBNavigationLocationManager * _Nullable)locationManager __attribute__((objc_designated_initializer));
        [Export("initWithRoute:directions:style:locationManager:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRoute route, MBDirections directions, [NullAllowed] MBStyle[] styles, [NullAllowed] MBNavigationLocationManager locationManager);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewWillDisappear:(BOOL)animated;
        [Export("viewWillDisappear:")]
        void ViewWillDisappear(bool animated);

        // -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("routeController:shouldRerouteFromLocation:")]
        bool RouteControllerShouldReroute(MBRouteController routeController, CLLocation location);

        // -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export("routeController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool RouteControllerShouldIncrementLegWhenArriving(MBRouteController routeController, MBWaypoint waypoint);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:willRerouteFromLocation:")]
        void RouteControllerWillReroute(MBRouteController routeController, CLLocation location);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export("routeController:didRerouteAlongRoute:")]
        void RouteControllerDidReroute(MBRouteController routeController, MBRoute route);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export("routeController:didFailToRerouteWithError:")]
        void RouteControllerDidFailToReroute(MBRouteController routeController, NSError error);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export("routeController:didUpdateLocations:")]
        void RouteControllerDidUpdateLocations(MBRouteController routeController, CLLocation[] locations);

        // -(void)routeController:(MBRouteController * _Nonnull)routeController didDiscardLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:didDiscardLocation:")]
        void RouteControllerDidDiscardLocation(MBRouteController routeController, CLLocation location);
    }

    partial interface IMBNavigationViewControllerDelegate {}
    // @protocol MBNavigationViewControllerDelegate
    [Protocol, Model]
    interface MBNavigationViewControllerDelegate
    {
        // @optional -(void)navigationViewControllerDidCancelNavigation:(MBNavigationViewController * _Nonnull)navigationViewController;
        [Export("navigationViewControllerDidCancelNavigation:")]
        void NavigationViewControllerDidCancelNavigation(MBNavigationViewController navigationViewController);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didArriveAt:(MBWaypoint * _Nonnull)waypoint;
        [Export("navigationViewController:didArriveAt:")]
        void NavigationViewControllerDidArrive(MBNavigationViewController navigationViewController, MBWaypoint waypoint);

        // @optional -(BOOL)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("navigationViewController:shouldRerouteFromLocation:")]
        bool NavigationViewControllerShouldReroute(MBNavigationViewController navigationViewController, CLLocation location);

        // @optional -(BOOL)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export("navigationViewController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool NavigationViewControllerShouldIncrementLegWhenArriving(MBNavigationViewController navigationViewController, MBWaypoint waypoint);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export("navigationViewController:willRerouteFromLocation:")]
        void NavigationViewControllerWillRereoute(MBNavigationViewController navigationViewController, CLLocation location);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export("navigationViewController:didRerouteAlongRoute:")]
        void NavigationViewController(MBNavigationViewController navigationViewController, MBRoute route);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export("navigationViewController:didFailToRerouteWithError:")]
        void NavigationViewControllerDidFailToReroute(MBNavigationViewController navigationViewController, NSError error);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetRouteStyleLayerInNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView routeCasingStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:routeCasingStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetRouteCasingStyleLayerInNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeDescribing:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeDescribing:")]
        [return: NullAllowed]
        MGLShape GetShapeDescribingInNavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView simplifiedShapeDescribing:(MBRoute * _Nonnull)route __attribute__((warn_unused_result));
        [Export("navigationMapView:simplifiedShapeDescribing:")]
        [return: NullAllowed]
        MGLShape GetSimplifiedShapeDescribingInNavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetWaypointStyleLayerInNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLStyleLayer * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView waypointSymbolStyleLayerWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((warn_unused_result));
        [Export("navigationMapView:waypointSymbolStyleLayerWithIdentifier:source:")]
        [return: NullAllowed]
        MGLStyleLayer GetWaypointSymbolStyleLayerInNavigationMapView(MBNavigationMapView mapView, string identifier, MGLSource source);

        // @optional -(MGLShape * _Nullable)navigationMapView:(MBNavigationMapView * _Nonnull)mapView shapeFor:(NSArray<MBWaypoint *> * _Nonnull)waypoints __attribute__((warn_unused_result));
        [Export("navigationMapView:shapeFor:")]
        [return: NullAllowed]
        MGLShape GetShapeInNavigationMapView(MBNavigationMapView mapView, MBWaypoint[] waypoints);

        // @optional -(void)navigationMapView:(MBNavigationMapView * _Nonnull)mapView didTap:(MBRoute * _Nonnull)route;
        [Export("navigationMapView:didTap:")]
        void DidTapOnRouteInNavigationMapView(MBNavigationMapView mapView, MBRoute route);

        // @optional -(MGLAnnotationImage * _Nullable)navigationMapView:(id)mapView imageFor:(id<MGLAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
        [Export("navigationMapView:imageFor:")]
        [return: NullAllowed]
        MGLAnnotationImage GetAnnotationImageInNavigationMapView(NSObject mapView, MGLAnnotation annotation);

        // @optional -(MGLAnnotationView * _Nullable)navigationMapView:(id)mapView viewFor:(id<MGLAnnotation> _Nonnull)annotation __attribute__((warn_unused_result));
        [Export("navigationMapView:viewFor:")]
        [return: NullAllowed]
        MGLAnnotationView GetAnnotationViewInNavigationMapView(NSObject mapView, MGLAnnotation annotation);

        // @optional -(void)navigationViewControllerDidOpenFeedback:(MBNavigationViewController * _Nonnull)viewController;
        [Export("navigationViewControllerDidOpenFeedback:")]
        void NavigationViewControllerDidOpenFeedback(MBNavigationViewController viewController);

        // @optional -(void)navigationViewControllerDidCancelFeedback:(MBNavigationViewController * _Nonnull)viewController;
        [Export("navigationViewControllerDidCancelFeedback:")]
        void NavigationViewControllerDidCancelFeedback(MBNavigationViewController viewController);

        // @optional -(void)navigationViewController:(MBNavigationViewController * _Nonnull)viewController didSend:(NSString * _Nonnull)feedbackId feedbackType:(enum MBFeedbackType)feedbackType;
        [Export("navigationViewController:didSend:feedbackType:")]
        void NavigationViewControllerDidSendFeedback(MBNavigationViewController viewController, string feedbackId, MBFeedbackType feedbackType);

        // @optional -(CGPoint)navigationViewController:(MBNavigationViewController * _Nonnull)navigationViewController mapViewUserAnchorPoint:(MBNavigationMapView * _Nonnull)mapView __attribute__((warn_unused_result));
        [Export("navigationViewController:mapViewUserAnchorPoint:")]
        CGPoint GetUserAnchorPointInNavigationViewController(MBNavigationViewController navigationViewController, MBNavigationMapView mapView);
    }

    // @interface MBNextBannerView : UIView
    [BaseType(typeof(UIView))]
    interface MBNextBannerView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBReportButton : MBButton
    [BaseType(typeof(MBButton))]
    interface MBReportButton
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBSeparatorView : UIView
    [BaseType(typeof(UIView))]
    interface MBSeparatorView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBStatusView : UIView
    [BaseType(typeof(UIView))]
    interface MBStatusView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBStepInstructionsView : BaseInstructionsBannerView
    [BaseType(typeof(BaseInstructionsBannerView))]
    interface MBStepInstructionsView
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBStepTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    interface MBStepTableViewCell
    {
        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }



    // @interface MBStepsBackgroundView : UIView
    [BaseType(typeof(UIView))]
    interface MBStepsBackgroundView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBStepsViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface MBStepsViewController: IUITableViewDelegate, IUITableViewDataSource
    {
        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }


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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBTitleLabel : MBStylableLabel
    [BaseType(typeof(MBStylableLabel))]
    interface MBTitleLabel
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

    partial interface IMBUserCourseView {}
    // @interface MBUserPuckCourseView : UIView <MBUserCourseView>
    [BaseType(typeof(UIView))]
    interface MBUserPuckCourseView : IMBUserCourseView
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)updateWithLocation:(CLLocation * _Nonnull)location pitch:(CGFloat)pitch direction:(CLLocationDegrees)direction animated:(BOOL)animated tracksUserCourse:(BOOL)tracksUserCourse;
        [Export("updateWithLocation:pitch:direction:animated:tracksUserCourse:")]
        void UpdateWithLocation(CLLocation location, nfloat pitch, double direction, bool animated, bool tracksUserCourse);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
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

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBDistanceFormatter : NSLengthFormatter
    [BaseType(typeof(NSLengthFormatter))]
    [DisableDefaultCtor]
    interface MBDistanceFormatter
    {
        // -(instancetype _Nonnull)initWithApproximate:(BOOL)approximate __attribute__((objc_designated_initializer));
        [Export("initWithApproximate:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool approximate);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);

        // -(void)encodeWithCoder:(NSCoder * _Nonnull)aCoder;
        [Export("encodeWithCoder:")]
        void EncodeWithCoder(NSCoder aCoder);

        // -(NSString * _Nonnull)stringFrom:(CLLocationDistance)distance __attribute__((warn_unused_result));
        [Export("stringFrom:")]
        string StringFrom(double distance);

        // -(NSString * _Nonnull)stringFromMeters:(double)numberInMeters __attribute__((warn_unused_result));
        [Export("stringFromMeters:")]
        string StringFromMeters(double numberInMeters);
    }

    // @interface MBNavigationLocationManager : CLLocationManager
    [BaseType(typeof(CLLocationManager))]
    interface MBNavigationLocationManager
    {
    }

    [BaseType(typeof(MBRouteOptions))]
    // @interface MBNavigationRouteOptions
    interface MBNavigationRouteOptions
    {
        // -(instancetype _Nonnull)initWithWaypoints:(NSArray<MBWaypoint *> * _Nonnull)waypoints profileIdentifier:(id)profileIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithWaypoints:profileIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBWaypoint[] waypoints, NSObject profileIdentifier);

        // -(instancetype _Nonnull)initWithLocations:(NSArray<CLLocation *> * _Nonnull)locations profileIdentifier:(id)profileIdentifier;
        [Export("initWithLocations:profileIdentifier:")]
        IntPtr Constructor(CLLocation[] locations, NSObject profileIdentifier);

        // -(instancetype _Nonnull)initWithCoordinates:(NSArray<NSValue *> * _Nonnull)coordinates profileIdentifier:(id)profileIdentifier;
        [Export("initWithCoordinates:profileIdentifier:")]
        IntPtr Constructor(NSValue[] coordinates, NSObject profileIdentifier);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)decoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder decoder);
    }

    // @interface MBReplayLocationManager : MBNavigationLocationManager
    [BaseType(typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBReplayLocationManager
    {
        // @property (nonatomic) NSTimeInterval speedMultiplier;
        [Export("speedMultiplier")]
        double SpeedMultiplier { get; set; }

        // @property (copy, nonatomic) NSArray<CLLocation *> * _Null_unspecified locations;
        [Export("locations", ArgumentSemantic.Copy)]
        CLLocation[] Locations { get; set; }

        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(void)startUpdatingLocation;
        [Export("startUpdatingLocation")]
        void StartUpdatingLocation();

        // -(void)stopUpdatingLocation;
        [Export("stopUpdatingLocation")]
        void StopUpdatingLocation();
    }

    // @interface MBRouteController : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteController: ICLLocationManagerDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        IMBRouteControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MBRouteControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        IMBRouteControllerDelegate WeakDelegate { get; set; }

        // @property (nonatomic, strong) MBDirections * _Nonnull directions;
        [Export("directions", ArgumentSemantic.Strong)]
        MBDirections Directions { get; set; }

        // @property (nonatomic, strong) MBNavigationLocationManager * _Null_unspecified locationManager;
        [Export("locationManager", ArgumentSemantic.Strong)]
        MBNavigationLocationManager LocationManager { get; set; }

        // @property (nonatomic) BOOL isDeadReckoningEnabled;
        [Export("isDeadReckoningEnabled")]
        bool IsDeadReckoningEnabled { get; set; }

        // @property (nonatomic) BOOL reroutesOpportunistically;
        [Export("reroutesOpportunistically")]
        bool ReroutesOpportunistically { get; set; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route directions:(MBDirections * _Nonnull)directions locationManager:(MBNavigationLocationManager * _Nonnull)locationManager __attribute__((objc_designated_initializer));
        [Export("initWithRoute:directions:locationManager:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRoute route, MBDirections directions, MBNavigationLocationManager locationManager);

        // -(void)resume;
        [Export("resume")]
        void Resume();

        // -(void)suspendLocationUpdates;
        [Export("suspendLocationUpdates")]
        void SuspendLocationUpdates();

        // @property (readonly, nonatomic) CLLocationDistance reroutingTolerance;
        [Export("reroutingTolerance")]
        double ReroutingTolerance { get; }

        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(NSString * _Nonnull)recordFeedbackWithType:(enum MBFeedbackType)type description:(NSString * _Nullable)description __attribute__((warn_unused_result));
        [Export("recordFeedbackWithType:description:")]
        string RecordFeedbackWithType(MBFeedbackType type, [NullAllowed] string description);

        // -(void)updateFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId type:(enum MBFeedbackType)type source:(enum MBFeedbackSource)source description:(NSString * _Nullable)description;
        [Export("updateFeedbackWithFeedbackId:type:source:description:")]
        void UpdateFeedbackWithFeedbackId(string feedbackId, MBFeedbackType type, MBFeedbackSource source, [NullAllowed] string description);

        // -(void)cancelFeedbackWithFeedbackId:(NSString * _Nonnull)feedbackId;
        [Export("cancelFeedbackWithFeedbackId:")]
        void CancelFeedbackWithFeedbackId(string feedbackId);

        // -(BOOL)userIsOnRoute:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("userIsOnRoute:")]
        bool UserIsOnRoute(CLLocation location);
    }

    partial interface IMBRouteControllerDelegate {}
    // @protocol MBRouteControllerDelegate
    [Protocol, Model]
    interface MBRouteControllerDelegate
    {
        // @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldRerouteFromLocation:(CLLocation * _Nonnull)location __attribute__((warn_unused_result));
        [Export("routeController:shouldRerouteFromLocation:")]
        bool RouteController(MBRouteController routeController, CLLocation location);

        // @optional -(BOOL)routeController:(MBRouteController * _Nonnull)routeController shouldIncrementLegWhenArrivingAtWaypoint:(MBWaypoint * _Nonnull)waypoint __attribute__((warn_unused_result));
        [Export("routeController:shouldIncrementLegWhenArrivingAtWaypoint:")]
        bool RouteController(MBRouteController routeController, MBWaypoint waypoint);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController willRerouteFromLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:willRerouteFromLocation:")]
        void RouteControllerWillReroute(MBRouteController routeController, CLLocation location);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didDiscardLocation:(CLLocation * _Nonnull)location;
        [Export("routeController:didDiscardLocation:")]
        void RouteControllerDidDiscardLocation(MBRouteController routeController, CLLocation location);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didRerouteAlongRoute:(MBRoute * _Nonnull)route;
        [Export("routeController:didRerouteAlongRoute:")]
        void RouteController(MBRouteController routeController, MBRoute route);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didFailToRerouteWithError:(NSError * _Nonnull)error;
        [Export("routeController:didFailToRerouteWithError:")]
        void RouteController(MBRouteController routeController, NSError error);

        // @optional -(void)routeController:(MBRouteController * _Nonnull)routeController didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
        [Export("routeController:didUpdateLocations:")]
        void RouteController(MBRouteController routeController, CLLocation[] locations);
    }

    // @interface MBRouteLegProgress : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteLegProgress
    {
        // @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull leg;
        [Export("leg", ArgumentSemantic.Strong)]
        MBRouteLeg Leg { get; }

        // @property (nonatomic) NSInteger stepIndex;
        [Export("stepIndex")]
        nint StepIndex { get; set; }

        // @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export("distanceTraveled")]
        double DistanceTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export("durationRemaining")]
        double DurationRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (nonatomic) BOOL userHasArrivedAtWaypoint;
        [Export("userHasArrivedAtWaypoint")]
        bool UserHasArrivedAtWaypoint { get; set; }

        // -(MBRouteStep * _Nullable)stepBefore:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export("stepBefore:")]
        [return: NullAllowed]
        MBRouteStep StepBefore(MBRouteStep step);

        // -(MBRouteStep * _Nullable)stepAfter:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export("stepAfter:")]
        [return: NullAllowed]
        MBRouteStep StepAfter(MBRouteStep step);

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable priorStep;
        [NullAllowed, Export("priorStep", ArgumentSemantic.Strong)]
        MBRouteStep PriorStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull currentStep;
        [Export("currentStep", ArgumentSemantic.Strong)]
        MBRouteStep CurrentStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable upComingStep;
        [NullAllowed, Export("upComingStep", ArgumentSemantic.Strong)]
        MBRouteStep UpComingStep { get; }

        // @property (readonly, nonatomic, strong) MBRouteStep * _Nullable followOnStep;
        [NullAllowed, Export("followOnStep", ArgumentSemantic.Strong)]
        MBRouteStep FollowOnStep { get; }

        // -(BOOL)isCurrentStep:(MBRouteStep * _Nonnull)step __attribute__((warn_unused_result));
        [Export("isCurrentStep:")]
        bool IsCurrentStep(MBRouteStep step);

        // @property (nonatomic, strong) MBRouteStepProgress * _Nonnull currentStepProgress;
        [Export("currentStepProgress", ArgumentSemantic.Strong)]
        MBRouteStepProgress CurrentStepProgress { get; set; }

        // -(instancetype _Nonnull)initWithLeg:(MBRouteLeg * _Nonnull)leg stepIndex:(NSInteger)stepIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export("initWithLeg:stepIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRouteLeg leg, nint stepIndex, nint spokenInstructionIndex);

        // @property (readonly, copy, nonatomic) NSArray<NSValue *> * _Nonnull nearbyCoordinates;
        [Export("nearbyCoordinates", ArgumentSemantic.Copy)]
        NSValue[] NearbyCoordinates { get; }
    }

    // @interface MBRouteProgress : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteProgress
    {
        // @property (readonly, nonatomic, strong) MBRoute * _Nonnull route;
        [Export("route", ArgumentSemantic.Strong)]
        MBRoute Route { get; }

        // @property (nonatomic) NSInteger legIndex;
        [Export("legIndex")]
        nint LegIndex { get; set; }

        // @property (readonly, nonatomic, strong) MBRouteLeg * _Nonnull currentLeg;
        [Export("currentLeg", ArgumentSemantic.Strong)]
        MBRouteLeg CurrentLeg { get; }

        // @property (readonly, nonatomic) CLLocationDistance distanceTraveled;
        [Export("distanceTraveled")]
        double DistanceTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export("durationRemaining")]
        double DurationRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export("distanceRemaining")]
        double DistanceRemaining { get; }

        // @property (readonly, copy, nonatomic) NSArray<MBWaypoint *> * _Nonnull remainingWaypoints;
        [Export("remainingWaypoints", ArgumentSemantic.Copy)]
        MBWaypoint[] RemainingWaypoints { get; }

        // @property (nonatomic, strong) MBRouteLegProgress * _Null_unspecified currentLegProgress;
        [Export("currentLegProgress", ArgumentSemantic.Strong)]
        MBRouteLegProgress CurrentLegProgress { get; set; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route legIndex:(NSInteger)legIndex spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export("initWithRoute:legIndex:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRoute route, nint legIndex, nint spokenInstructionIndex);
    }


    // @interface MBRouteStepFormatter : NSFormatter
    [BaseType(typeof(NSFormatter))]
    interface MBRouteStepFormatter
    {
        // -(NSString * _Nullable)stringForObjectValue:(id _Nullable)obj __attribute__((warn_unused_result));
        [Export("stringForObjectValue:")]
        [return: NullAllowed]
        string StringForObjectValue([NullAllowed] NSObject obj);

        // -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error __attribute__((warn_unused_result));
        [Export("getObjectValue:forString:errorDescription:")]
        bool GetObjectValue([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface MBRouteStepProgress : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MBRouteStepProgress
    {
        // @property (readonly, nonatomic, strong) MBRouteStep * _Nonnull step;
        [Export("step", ArgumentSemantic.Strong)]
        MBRouteStep Step { get; }

        // @property (nonatomic) CLLocationDistance distanceTraveled;
        [Export("distanceTraveled")]
        double DistanceTraveled { get; set; }

        // @property (nonatomic) CLLocationDistance userDistanceToManeuverLocation;
        [Export("userDistanceToManeuverLocation")]
        double UserDistanceToManeuverLocation { get; set; }

        // @property (readonly, nonatomic) CLLocationDistance distanceRemaining;
        [Export("distanceRemaining")]
        double DistanceRemaining { get; }

        // @property (readonly, nonatomic) double fractionTraveled;
        [Export("fractionTraveled")]
        double FractionTraveled { get; }

        // @property (readonly, nonatomic) NSTimeInterval durationRemaining;
        [Export("durationRemaining")]
        double DurationRemaining { get; }

        // -(instancetype _Nonnull)initWithStep:(MBRouteStep * _Nonnull)step spokenInstructionIndex:(NSInteger)spokenInstructionIndex __attribute__((objc_designated_initializer));
        [Export("initWithStep:spokenInstructionIndex:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRouteStep step, nint spokenInstructionIndex);

        // @property (copy, nonatomic) NSArray<MBIntersection *> * _Nullable intersectionsIncludingUpcomingManeuverIntersection;
        [NullAllowed, Export("intersectionsIncludingUpcomingManeuverIntersection", ArgumentSemantic.Copy)]
        MBIntersection[] IntersectionsIncludingUpcomingManeuverIntersection { get; set; }

        // @property (readonly, nonatomic, strong) MBIntersection * _Nullable upcomingIntersection;
        [NullAllowed, Export("upcomingIntersection", ArgumentSemantic.Strong)]
        MBIntersection UpcomingIntersection { get; }

        // @property (nonatomic) NSInteger intersectionIndex;
        [Export("intersectionIndex")]
        nint IntersectionIndex { get; set; }

        // @property (nonatomic) NSInteger spokenInstructionIndex;
        [Export("spokenInstructionIndex")]
        nint SpokenInstructionIndex { get; set; }

        // @property (readonly, nonatomic, strong) MBSpokenInstruction * _Nullable currentSpokenInstruction;
        [NullAllowed, Export("currentSpokenInstruction", ArgumentSemantic.Strong)]
        MBSpokenInstruction CurrentSpokenInstruction { get; }
    }

    // @interface MBSimulatedLocationManager : MBNavigationLocationManager
    [BaseType(typeof(MBNavigationLocationManager))]
    [DisableDefaultCtor]
    interface MBSimulatedLocationManager
    {
        // @property (readonly, nonatomic, strong) CLLocation * _Nullable location;
        [NullAllowed, Export("location", ArgumentSemantic.Strong)]
        CLLocation Location { get; }

        // -(instancetype _Nonnull)initWithRoute:(MBRoute * _Nonnull)route __attribute__((objc_designated_initializer));
        [Export("initWithRoute:")]
        [DesignatedInitializer]
        IntPtr Constructor(MBRoute route);

        // -(void)startUpdatingLocation;
        [Export("startUpdatingLocation")]
        void StartUpdatingLocation();

        // -(void)stopUpdatingLocation;
        [Export("stopUpdatingLocation")]
        void StopUpdatingLocation();
    }

    // @interface MBVisualInstructionFormatter : NSObject
    [BaseType(typeof(NSObject))]
    interface MBVisualInstructionFormatter
    {
        // -(NSString * _Nullable)stringWithLeg:(MBRouteLeg * _Nullable)leg step:(MBRouteStep * _Nullable)step __attribute__((warn_unused_result));
        [Export("stringWithLeg:step:")]
        [return: NullAllowed]
        string StringWithLeg([NullAllowed] MBRouteLeg leg, [NullAllowed] MBRouteStep step);
    }

    // @interface MapboxNavigation_Swift_987 (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_MapboxNavigation_Swift_987
    {
        // @property (readonly, nonatomic, strong) UIFont * _Nonnull adjustedFont;
        //[Export("adjustedFont", ArgumentSemantic.Strong)]
        [Export("adjustedFont")]
        UIFont GetAdjustedFont();
    }
}
