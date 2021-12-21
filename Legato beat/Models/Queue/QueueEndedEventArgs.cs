namespace Legato_beat.Models.Queue
{
    public class QueueEndedEventArgs : AudioItemEventArgs
    {
        public QueueEndedEventArgs(IAudioItem audioItem) : base(audioItem)
        {

        }
    }
}
