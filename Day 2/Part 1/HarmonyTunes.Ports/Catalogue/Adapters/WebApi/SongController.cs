using HarmonyTunes.Catalogue.Album.Application.interfaces;
using HarmonyTunes.Catalogue.Shared.Domain;
using HarmonyTunes.Catalogue.Song.Application.Interfaces;
using HarmonyTunes.Catalogue.Song.Domain.ValueObjects;
using HarmonyTunes.Ports.Catalogue.Models;

namespace HarmonyTunes.Ports.Catalogue.Adapters.WebApi
{
    public static class SongController
    {
        public static void RegisterController(WebApplication app)
        {
            app.MapPost("/api/songs/create", async (CreateSongDto dto, ISongService SongService) =>
            {
                var songId = await SongService.Create(new AlbumReference(dto.AlbumReference),
                    new SongName(dto.Name));

                return songId.Key;
            });
        }
    }
}
