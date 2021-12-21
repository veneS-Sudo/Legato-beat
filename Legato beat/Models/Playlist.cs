using System.Collections.ObjectModel;
using LiteDB;

namespace Legato_beat.Models
{
    public class Playlist
    {
        public const string CollectionName = "playlists";

        private string _title;

        public Playlist()
        {
            Tracks = new ObservableCollection<Track>();
        }

        public int PlaylistId { get; set; }

        public string Title
        {
            get
            {
                if (string.IsNullOrEmpty(_title))
                    return "Unknow Playlist";
                return _title;
            }
            set => _title = value;
        }

        public bool IsFavorite { get; set; }

        [BsonRef(Track.CollectionName)]
        public ObservableCollection<Track> Tracks { get; set; }
    }
}
