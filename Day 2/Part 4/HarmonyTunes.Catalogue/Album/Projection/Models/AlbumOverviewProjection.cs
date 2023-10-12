using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Album.Projection.Models
{
    public class AlbumOverviewProjection
    {
        public Guid Id { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int NumberOfSongs { get; set; }
    }
}
