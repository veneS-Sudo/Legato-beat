namespace Legato_beat.Models
{
    public class QueueChangedEventArgs : AudioItemEventArgs
    {
        public QueueChangedEventArgs(IAudioItem audioItem) : base(audioItem)
        {

        }
    }
}
