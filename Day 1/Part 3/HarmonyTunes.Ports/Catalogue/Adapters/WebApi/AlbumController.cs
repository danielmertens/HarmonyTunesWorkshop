using HarmonyTunes.Catalogue.Album.Application.interfaces;
using HarmonyTunes.Catalogue.Album.Application.Models;
using HarmonyTunes.Catalogue.Album.Domain.ValueObjects;
using HarmonyTunes.Catalogue.Shared.Domain;
using HarmonyTunes.Ports.Catalogue.Models;

namespace HarmonyTunes.Ports.Catalogue.Adapters.WebApi;

public static class AlbumController
{
    public static void RegisterControllers(WebApplication app)
    {
        app.MapPost("/api/albums/create", async (CreateAlbumDto dto, IAlbumService albumService) =>
        {
            var albumId = await albumService.CreateAlbum(new AlbumName(dto.Name));

            return albumId.Key;
        });

        app.MapPost("/api/albums/update", async (AlbumDetailsDto dto, IAlbumService albumService) =>
        {
            await albumService.UpdateAlbum(
                new AlbumReference(dto.AlbumReference),
                new AlbumDetails
                {
                    Description = new AlbumDescription(dto.Description),
                    BackgroundImageUrl = new Url(dto.BackgroundImageUrl),
                    PublicationYear = new Year(dto.Year)
                });
        });
    }
}
