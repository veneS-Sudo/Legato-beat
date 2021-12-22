
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Legato_beat.Models.Queue
{
    public class Queue : IAudioQueue
    {
        private int _currentIndex = 0;

        public Queue()
        {
            AudioItems = new ObservableCollection<IAudioItem>();
        }

        public IAudioItem this[int index] { get => AudioItems[index]; set => AudioItems[index] = value; }

        public ObservableCollection<IAudioItem> AudioItems {get; protected set;}

        public bool HasNext => Count > CurrentIndex + 1;

        public bool HasPrevious => CurrentIndex > 0;

        public IAudioItem? Next 
        { 
            get
            {
                if(HasNext)
                    return AudioItems[CurrentIndex+1];
                return null;
            }
        }

        public IAudioItem? Previous 
        { 
            get
            {
                if (HasPrevious)
                    return AudioItems[CurrentIndex - 1];
                return null;
            }
        }

        public bool HasCurrent => this.ElementAtOrDefault(CurrentIndex) != null;

        public IAudioItem? Current
        {
            get
            {
                return this.ElementAtOrDefault(_currentIndex);
            }
            set
            {
                CurrentIndex = AudioItems.IndexOf(value);
            }

        }

        public int Count => AudioItems.Count;

        public bool IsReadOnly => false;

        public int CurrentIndex 
        { 
            get => _currentIndex;
            set
            {
                _currentIndex = value;
                OnPropertyChanged("CurrentIndex");
                if (HasCurrent)
                {
                    OnQueueChanged(this, new QueueChangedEventArgs(Current));
                }
            }
        }

        public event QueueEndedEventHandler QueueEnded;
        public event QueueChangedEventHandler QueueChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnQueueChanged(object sender, QueueChangedEventArgs args)
        {
            QueueChanged?.Invoke(sender, args);
        }

        internal void OnQueueEnded(object sender, QueueEndedEventArgs args)
        {
            QueueEnded?.Invoke(sender, args);
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public void Add(IAudioItem item)
        {
            AudioItems.Add(item);
        }

        public void Clear()
        {
            AudioItems.Clear();
        }

        public bool Contains(IAudioItem item)
        {
            return AudioItems.Contains(item);
        }

        public void CopyTo(IAudioItem[] array, int arrayIndex)
        {
            AudioItems.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IAudioItem> GetEnumerator()
        {
            return AudioItems.GetEnumerator();
        }

        public int IndexOf(IAudioItem item)
        {
            return AudioItems.IndexOf(item);   
        }

        public void Insert(int index, IAudioItem item)
        {
            AudioItems.Insert(index, item);
        }

        public bool Remove(IAudioItem item)
        {
            return AudioItems.Remove(item);
        }

        public void RemoveAt(int index)
        {
            AudioItems.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return AudioItems.GetEnumerator();
        }
    }
}
