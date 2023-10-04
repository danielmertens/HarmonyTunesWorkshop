using HarmonyTunes.Catalogue.Album.Domain;
using HarmonyTunes.Catalogue.Shared.Domain;

namespace HarmonyTunes.Catalogue.Album.Application.interfaces;

public interface IAlbumRepository
{
    void Add(AlbumAggregate aggregateRoot);
    Task Commit();
    Task<AlbumAggregate> Fetch(AlbumReference albumReference);
    AlbumReference GetNextIdentity();
    void Update(AlbumAggregate aggregateRoot);
}