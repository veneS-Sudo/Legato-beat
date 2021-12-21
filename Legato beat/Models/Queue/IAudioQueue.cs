using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Legato_beat.Models.Queue
{
    public delegate void QueueEndedEventHandler(object sender, QueueEndedEventArgs e);
    public delegate void QueueChangedEventHandler(object sender, QueueChangedEventArgs e);
    public interface IAudioQueue : IList<IAudioItem>, INotifyPropertyChanged
    {
        ObservableCollection<IAudioItem> AudioItems { get; }

        event QueueEndedEventHandler QueueEnded;
        event QueueEndedEventHandler QueueChanged;
        /// <summary>
        /// if the queue has next audio item
        /// </summary>
        bool HasNext { get; }

        /// <summary>
        /// if the queue has previous audio item
        /// </summary>
        bool HasPrevious { get; }

        /// <summary>
        /// get the next audio item
        /// </summary>
        IAudioItem Next { get; }

        /// <summary>
        /// get the previous audio item
        /// </summary>
        IAudioItem Previous { get; }

        /// <summary>
        /// if the queue has a audio item it can currently play
        /// </summary>
        bool HasCurrent { get; }

        /// <summary>
        /// get the current audio item from queue
        /// </summary>
        IAudioItem Current { get; }
    }
}
