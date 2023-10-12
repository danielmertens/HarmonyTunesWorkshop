using HarmonyTunes.Catalogue.Album.Projection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Album.Projection.Interfaces
{
    public interface IAlbumProjectionsRepository
    {
        void AddOrUpdateProjection(AlbumOverviewProjection projection);
        Task Commit();
    }
}
