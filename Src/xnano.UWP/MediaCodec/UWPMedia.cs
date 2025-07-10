using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using xnano.UWP.Gamestream;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Java.Interop;
//using Java.Lang;
//using Java.Nio;

namespace UWP.Media
{

    //
    // Summary:
    //     MediaCodec class can be used to access low-level media codecs, i.
    //
    // Remarks:
    //     Java documentation for
    //
    //     android.media.MediaCodec
    //
    //     .
    //
    //     Portions of this page are modifications based on work created and shared by the
    //     Android Open Source Project and used according to terms described in the Creative
    //     Commons 2.5 Attribution License.
    //[Register("android/media/MediaCodec", DoNotGenerateAcw = true)]
    public sealed class MediaCodec //: Java.Lang.Object
    {
        public object Name;

        public static MediaCodec CreateDecoderByType(string mimeType)
        {
            throw new NotImplementedException();
        }

        public void Configure(MediaFormat format, Surface surface, object crypto, object flags)
        {
            throw new NotImplementedException();
        }

        public NioByteBuffer GetInputBuffer(int index)
        {
            throw new NotImplementedException();
        }

        public void QueueInputBuffer(int index, int v1, int v2, int v3, object none)
        {
            throw new NotImplementedException();
        }

        public NioByteBuffer GetOutputBuffer(int index)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        internal void SetCallback(VideoDecoder videoDecoder)
        {
            throw new NotImplementedException();
        }

        internal void SetVideoScalingMode(object scaleToFit)
        {
            throw new NotImplementedException();
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }

        internal void Stop()
        {
            throw new NotImplementedException();
        }

        internal void ReleaseOutputBuffer(int index, bool v)
        {
            throw new NotImplementedException();
        }

        internal void Release()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal int DequeueOutputBuffer(BufferInfo info, int v)
        {
            throw new NotImplementedException();
        }

        internal int DequeueInputBuffer(int v)
        {
            throw new NotImplementedException();
        }

        public class Callback
        {
            public virtual void OnInputBufferAvailable(MediaCodec codec, int index)
            {
                throw new NotImplementedException();
            }
           
            public virtual void OnError(MediaCodec codec, CodecException e)
            {
                throw new NotImplementedException();
            }
            public virtual void OnOutputFormatChanged(MediaCodec codec, MediaFormat format)
            {
                throw new NotImplementedException();
            }

            public virtual void OnOutputBufferAvailable(MediaCodec codec, int index, MediaCodec.BufferInfo info = default)
            {
                throw new NotImplementedException();
            }

            internal void Dispose(bool v)
            {
                throw new NotImplementedException();
            }
        }

        public class CodecException : Exception
        {
        }

        public class BufferInfo
        {
        }
    }
}
