using Pacco.Services.Availability.Core.Entities;
using Pacco.Services.Availability.Core.ValueObjects;
using System;
using System.Linq;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal static class Extensions
    {



        public static Resource AsEntity(this ResourceDocument document)
           => new Resource(document.Id, document.Tags, document.Reservations?
               .Select(r => new Reservation(r.TimeStamp.AsDateTime(), r.Priority)), document.Version);
        public static ResourceDocument AsDocument(this Resource resource)
           => new ResourceDocument()
           {
               Id = resource.Id,
               Reservations = resource.Reservations.Select(r => new ReservationDocument() { Priority = r.Priority, TimeStamp = r.DateTime.AsDaysSinceEpoth() }),
               Tags = resource.Tags,
               Version = resource.Version
           };

        public static int AsDaysSinceEpoth(this DateTime dateTime)
            => (dateTime - new DateTime()).Days;

        public static DateTime AsDateTime(this int timeStamp)
            => (new DateTime()).AddDays(timeStamp);

    }
}
