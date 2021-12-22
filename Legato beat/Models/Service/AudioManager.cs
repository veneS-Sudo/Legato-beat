using System;
using System.Threading.Tasks;
using Legato_beat.Models.Queue;
using NetCoreAudio;
using NetCoreAudio.Interfaces;

namespace Legato_beat.Models.Service
{
    internal class AudioManager : IAudioManager
    {
        private IPlayer _player;
        public AudioManager()
        {
            Player = new Player();
            Queue = new Queue.Queue();
        }

        public IPlayer Player
        {
            get => _player;
            init
            {
                if (_player == null)
                   _player = value;
            }
        }

        public IAudioQueue Queue { get; set; }



        public async Task<bool> PlayQueueItem(IAudioItem item)
        {
            if (Queue == null || !Queue.Contains(item)) 
                return false;
            Queue.CurrentIndex = Queue.IndexOf(item);
            await Player.Play(item.AudioUri);
            return true;
        }

        public async Task<bool> PlayQueueItem(int index)
        {
            
            if (index >= Queue.Count || index < 0)
                return false;

            Queue.CurrentIndex = index;
            await Player.Play(Queue[index].AudioUri);
            return true;
        }

        public async Task<bool> PlayNext()
        {
            if (!Queue.HasNext)
                return false;

            return await PlayQueueItem(Queue.Next);
        }

        public async Task<bool> PlayPrevious()
        {
            if (!Queue.HasPrevious)
                return false;

            return await PlayQueueItem(Queue.Previous);
        }
    }
}
