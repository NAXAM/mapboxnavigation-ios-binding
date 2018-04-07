using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MapboxSpeech
{
    [Native]
    public enum MBAudioFormat : ulong {
      Mp3 = 0,
      OggVorbis = 1,
      Pcm = 2,
    }

    [Native]
    public enum MBSpeechGender : ulong {
      Female = 0,
      Male = 1,
      Neuter = 2,
    }

    [Native]
    public enum MBTextType : ulong {
      Text = 0,
      Ssml = 1,
    }
}
