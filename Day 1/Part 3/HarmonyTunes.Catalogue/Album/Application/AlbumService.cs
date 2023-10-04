using HarmonyTunes.Catalogue.Album.Application.interfaces;
using HarmonyTunes.Catalogue.Album.Application.Models;
using HarmonyTunes.Catalogue.Album.Domain;
using HarmonyTunes.Catalogue.Album.Domain.ValueObjects;
using HarmonyTunes.Catalogue.Shared.Domain;

namespace HarmonyTunes.Catalogue.Album.Application;

public class AlbumService : IAlbumService
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumService(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<AlbumReference> CreateAlbum(AlbumName albumName)
    {
        var identity = _albumRepository.GetNextIdentity();
        var aggregateRoot = new AlbumAggregate(identity);

        aggregateRoot.Create(albumName);

        _albumRepository.Add(aggregateRoot);
        await _albumRepository.Commit();

        return identity;
    }

    public async Task UpdateAlbum(AlbumReference albumReference, AlbumDetails albumDetails)
    {
        var aggregateRoot = await _albumRepository.Fetch(albumReference);

        aggregateRoot.Update(albumDetails);

        _albumRepository.Update(aggregateRoot);
        await _albumRepository.Commit();
    }
}
