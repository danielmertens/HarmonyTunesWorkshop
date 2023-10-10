using HarmonyTunes.Catalogue.Shared.Domain;
using HarmonyTunes.Catalogue.Song.Domain;
using HarmonyTunes.Domain.Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Song.Application.Interfaces
{
    public interface ISongRepository:
        IRepository<SongAggregate, SongState, SongReference>
    {
    }
}
