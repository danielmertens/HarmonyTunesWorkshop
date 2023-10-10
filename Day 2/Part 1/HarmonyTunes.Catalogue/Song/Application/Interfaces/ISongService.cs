using HarmonyTunes.Catalogue.Shared.Domain;
using HarmonyTunes.Catalogue.Song.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Song.Application.Interfaces
{
    public interface ISongService
    {
        Task<SongReference> Create(AlbumReference albumReference, SongName name);
    }
}
