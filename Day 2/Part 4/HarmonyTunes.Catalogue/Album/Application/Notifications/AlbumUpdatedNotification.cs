using HarmonyTunes.Catalogue.Shared.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Album.Application.Notifications
{
    public class AlbumUpdatedNotification: INotification
    {
        public Guid AlbumReference { get; set; }
    }
}
