using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MapboxSpeech
{
    //    SWIFT_CLASS_NAMED("SpeechOptions")
    //@interface MBSpeechOptions : NSObject<NSSecureCoding>
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    partial interface MBSpeechOptions : INSSecureCoding
    {
        //- (nonnull instancetype) initWithText:(NSString* _Nonnull) text OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithText:"), DesignatedInitializer]
        IntPtr Constructor(string text);

        //TODO
        ////- (nonnull instancetype) initWithSsml:(NSString* _Nonnull) ssml OBJC_DESIGNATED_INITIALIZER;
        //[Export("initWithSsml:"), DesignatedInitializer]
        [Static, Export("initWithSsml:")]
        MBSpeechOptions InitWithSsml(string ssml);

        //    /// <code>String</code> to create audiofile for. Can either be plain text or <a href="https://en.wikipedia.org/wiki/Speech_Synthesis_Markup_Language"><code>SSML</code></a>.
        //    /// If <code>SSML</code> is provided, <code>TextType</code> must be <code>TextType.ssml</code>.
        //    @property(nonatomic, copy) NSString* _Nonnull text;
        ///// Audio format for outputted audio file.
        //@property(nonatomic) enum MBAudioFormat outputFormat;
        [Export("outputFormat")]
        MBAudioFormat AudioFormat { get; set; }

        ///// The locale in which the audio is spoken.
        ///// By default, the user’s system locale will be used to decide upon an appropriate voice.
        //@property(nonatomic, copy) NSLocale* _Nonnull locale;
        [Export("locale")]
        NSLocale Locale { get; set; }

        ///// Gender of voice speeking text.
        ///// Note: not all languages have both genders.
        //@property(nonatomic) enum MBSpeechGender speechGender;
        [Export("speechGender")]
        MBSpeechGender SpeechGender { get; set; }
    }

    //    @class NSError;
    //@class NSURLSessionDataTask;

    //    SWIFT_CLASS_NAMED("SpeechSynthesizer")
    //@interface MBSpeechSynthesizer : NSObject
    [BaseType(typeof(NSObject))]
    partial interface MBSpeechSynthesizer
    {
        //SWIFT_CLASS_PROPERTY(@property (nonatomic, class, readonly, strong) MBSpeechSynthesizer* _Nonnull sharedSpeech;)
        //+ (MBSpeechSynthesizer* _Nonnull) sharedSpeech SWIFT_WARN_UNUSED_RESULT;
        [Static, Export("sharedSpeech")]
        MBSpeechSynthesizer SharedSpeech { get; }

        //- (nonnull instancetype) initWithAccessToken:(NSString* _Nullable) accessToken host:(NSString* _Nullable) host OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithAccessToken:host:"), DesignatedInitializer]
        IntPtr Constructor(string accessToken, string host);

        ///// Initializes a newly created Speech object with an optional access token.
        ///// \param accessToken A Mapbox <a href="https://www.mapbox.com/help/define-access-token/">access token</a>. If an access token is not specified when initializing the Speech object, it should be specified in the <code>MGLMapboxAccessToken</code> key in the main application bundle’s Info.plist.
        /////
        //- (nonnull instancetype) initWithAccessToken:(NSString* _Nullable) accessToken;
        [Export("initWithAccessToken:")]
        IntPtr Constructor(string accessToken);

        ///// Begins asynchronously fetching the audio file.
        ///// This method retrieves the audio asynchronously over a network connection. If a connection error or server error occurs, details about the error are passed into the given completion handler in lieu of the audio file.
        ///// \param options A <code>SpeechOptions</code> object specifying the requirements for the resulting audio file.
        /////
        ///// \param completionHandler The closure (block) to call with the resulting audio. This closure is executed on the application’s main thread.
        /////
        /////
        ///// returns:
        ///// The data task used to perform the HTTP request. If, while waiting for the completion handler to execute, you no longer want the resulting audio, cancel this task.
        //- (NSURLSessionDataTask* _Nonnull) speakSpeechWithOptions:(MBSpeechOptions* _Nonnull) options completionHandler:(void (^ _Nonnull)(NSData* _Nullable, NSError* _Nullable))completionHandler;
        [Export("speakSpeechWithOptions:completionHandler:")]
        NSUrlSessionDataTask SpeakSpeechWithOptions(MBSpeechOptions options, Action<NSData, NSError> completionHandler);
        ///// The HTTP URL used to fetch audio from the API.
        //- (NSURL* _Nonnull) URLForCalculatingSpeechWithOptions:(MBSpeechOptions* _Nonnull) options SWIFT_WARN_UNUSED_RESULT;
        [Export("URLForCalculatingSpeechWithOptions:")]
        NSUrl URLForCalculatingSpeechWithOptions(MBSpeechOptions options);
    }
}
