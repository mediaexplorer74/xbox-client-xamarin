using System;

namespace xnano.UWP.Gamestream
{
    public class MediaFormat
    {
        public static object KeyMaxWidth;
        public static object KeyMaxHeight;
        public static object KeyOperatingRate;
        internal static string MimetypeVideoAvc;
        internal static string MimetypeAudioAac;
        internal static object KeyMaxInputSize;
        internal static object KeyIsAdts;
        internal static object KeyAacProfile;

        internal static MediaFormat CreateAudioFormat(string mime, int sampleRate, int channelCount)
        {
            throw new NotImplementedException();
        }

        internal static MediaFormat CreateVideoFormat(string mime, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void SetByteBuffer(string v, object value)
        {
            throw new NotImplementedException();
        }

        public void SetInteger(object keyMaxWidth, int videoWidth)
        {
            throw new NotImplementedException();
        }

        public void SetInteger(object keyOperatingRate, object maxValue)
        {
            throw new NotImplementedException();
        }
    }
}