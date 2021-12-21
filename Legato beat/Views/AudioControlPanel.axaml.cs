using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Legato_beat.ViewModels;

namespace Legato_beat.Views
{
    public partial class AudioControlPanel : UserControl
    {
        public AudioControlPanel()
        {
            InitializeComponent();
            this.DataContext = new AudioControlPanelViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
