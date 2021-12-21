using System;

namespace Legato_beat.Models
{
    public class AudioItemEventArgs : EventArgs
    {
        public AudioItemEventArgs(IAudioItem audioItem)
        {
            AudioItem = audioItem;
        }

        public IAudioItem AudioItem { get; protected set; }
    }
}
