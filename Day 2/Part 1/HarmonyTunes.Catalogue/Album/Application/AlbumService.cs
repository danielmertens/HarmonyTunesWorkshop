using HarmonyTunes.Catalogue.Album.Application.interfaces;
using HarmonyTunes.Catalogue.Album.Application.Models;
using HarmonyTunes.Catalogue.Album.Domain;
using HarmonyTunes.Catalogue.Album.Domain.ValueObjects;
using HarmonyTunes.Catalogue.Shared.Domain;
using HarmonyTunes.Domain.Core.Application;

namespace HarmonyTunes.Catalogue.Album.Application;

public class AlbumService : 
    ApplicationService<AlbumAggregate, AlbumState, AlbumReference>,
    IAlbumService
{
    public AlbumService(IAlbumRepository albumRepository)
        : base(albumRepository)
    { }

    public async Task<AlbumReference> CreateAlbum(AlbumName albumName)
    {
        return await Add(agg => agg.Create(albumName));
    }

    public async Task PublishAlbum(AlbumReference albumReference)
    {
        await Update(albumReference, agg => agg.Publish());
    }

    public async Task UpdateAlbum(AlbumReference albumReference, AlbumDetails albumDetails)
    {
        await Update(albumReference, agg => agg.Update(albumDetails));
    }
}
