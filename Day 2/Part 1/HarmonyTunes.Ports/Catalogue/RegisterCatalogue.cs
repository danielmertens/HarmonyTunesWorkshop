using HarmonyTunes.Catalogue.Album.Application;
using HarmonyTunes.Catalogue.Album.Application.interfaces;
using HarmonyTunes.Catalogue.Song.Application;
using HarmonyTunes.Catalogue.Song.Application.Interfaces;
using HarmonyTunes.Ports.Catalogue.Adapters.Database;
using HarmonyTunes.Ports.Catalogue.Adapters.Database.Album;
using HarmonyTunes.Ports.Catalogue.Adapters.Database.Song;
using HarmonyTunes.Ports.Catalogue.Adapters.WebApi;

namespace HarmonyTunes.Ports.Catalogue;

public static class RegisterCatalogue
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IAlbumService, AlbumService>();
        services.AddScoped<IAlbumRepository, AlbumRepository>();

        services.AddScoped<ISongService, SongService>();
        services.AddScoped<ISongRepository, SongRepository>();

        services.AddDbContext<CatalogueContext>();
    }

    public static void RegisterControllers(WebApplication app)
    {
        AlbumController.RegisterControllers(app);
        SongController.RegisterController(app);
    }
}
