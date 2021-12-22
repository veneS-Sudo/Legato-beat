using Legato_beat.Models.Queue;
using NetCoreAudio.Interfaces;

namespace Legato_beat.Models.Service
{
    internal interface IAudioManager
    {
        IPlayer Player { get; init; }
        IAudioQueue Queue { get; set; }
    }
}
