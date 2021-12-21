using System;
using System.Reactive;
using ReactiveUI;
using NetCoreAudio;

namespace Legato_beat.ViewModels
{
    internal class AudioControlPanelViewModel : ViewModelBase
    {
        public Player Player { get; }
        public AudioControlPanelViewModel()
        {
            Player = new Player();
            PlayCommand = ReactiveCommand.Create(Play);
            ForwardCommand = ReactiveCommand.Create(Forward);
            BackCommand = ReactiveCommand.Create(Back);
        }
        public ReactiveCommand<Unit, Unit> PlayCommand { get; }
        public ReactiveCommand<Unit, Unit> ForwardCommand { get; }
        public ReactiveCommand<Unit, Unit> BackCommand { get; }

        async void Play()
        {
            if (!Player.Playing)
                await Player.Play(@"C:\Users\veryw\Music\Black Clover - Opening 10 (HD)-4evV8Fr5A8U.mp3");
            else if (Player.Paused)
                await Player.Resume();
        }

        async void Forward()
        {
            await Player.Play(@"C:\Users\veryw\Music\Skillet - Rise-91990713.mp3");
        }

        async void Back()
        {
            await Player.Play(@"C:\Users\veryw\Music\Black Clover - Opening 10 (HD)-4evV8Fr5A8U.mp3");
        }
    }
}
