using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonyTunes.Catalogue.Shared.Application.Interfaces
{
    public interface IMessagePublisher
    {
        Task Publish(INotification notification);
    }
}
