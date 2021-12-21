using LiteDB;

namespace Legato_beat.Models
{
    public class Artist
    {
        public const string CollectionName = "artists";

        private string _name;
        private string _country;

        public int ArtistId { get; set; }
        public bool IsFavorite { get; set; }

        public string Name 
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    return "Unknown Artist";
                return _name;
            }
            set => _name = value;
        }

        public string Country 
        { 
            get
            {
                if (string.IsNullOrEmpty(_country))
                    return "Unknown Country";
                return _country;
            }
            set => _country = value;
        }

        [BsonRef(Album.CollectionName)]
        public Album? Albums { get; set; }
    }
}
