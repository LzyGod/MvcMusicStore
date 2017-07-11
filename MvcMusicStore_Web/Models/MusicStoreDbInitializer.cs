using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore_Web.Models
{
    public class MusicStoreDbInitializer
        : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "周杰吧" });
            context.Genres.Add(new Genre { Name = "Jazz", Description = "九州" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "陈奕迅" },
                Genre = new Genre { Name = "asdsa" },
                Price = 9.9m,
                Title = "Carvan"
            });
            base.Seed(context);
        }
    }
}