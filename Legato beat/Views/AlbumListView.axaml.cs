using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Legato_beat.Views
{
    public partial class AlbumListView : UserControl
    {
        public AlbumListView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
