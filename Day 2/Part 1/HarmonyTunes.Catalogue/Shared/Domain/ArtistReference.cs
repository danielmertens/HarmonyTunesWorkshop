using HarmonyTunes.Domain.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Shared.Domain
{
    public class ArtistReference : Identity
    {
        public ArtistReference(Guid key)
            : base(key)
        { }
    }
}
