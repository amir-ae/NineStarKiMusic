using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NineStarKi.Models
{
    public class SessionCollection : Collection
    {
        public static Collection GetMusicians(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCollection collection = session?.GetJson<SessionCollection>("collection") ?? new SessionCollection();

            collection.Session = session;
            return collection;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public void SaveSession()
        {
            Session.SetJson("collection", this);
        }
    }
}
