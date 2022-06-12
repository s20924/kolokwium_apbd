using Microsoft.EntityFrameworkCore;

namespace przedKolokwium1.Models
{
    public class MainDbContext : DbContext
    {
        protected MainDbContext()
        {

        }
        public MainDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_Track> Musician_Tracks { get; set; }
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Musician>(p =>
            {
                p.HasData(
                    new Musician { IdMusician = 1, FirstName = "Alek", LastName = "Pietruszka" },
                    new Musician { IdMusician = 2, FirstName = "Paul", LastName = "Czosnek" }
                    );
            });

            modelBuilder.Entity<Musician_Track>(p =>
            {
                p.HasKey(c => new { c.IdTrack, c.IdMusician });
                p.HasData(
                    new Musician_Track { IdMusician = 1, IdTrack = 1 },
                    new Musician_Track { IdMusician = 2, IdTrack = 1 }
                    );
            });

            modelBuilder.Entity<Track>(p =>
            {
                p.HasData(
                    new Track { IdTrack = 1, TrackName = "ELdo", Duration = 2, IdMusicAlbum = 1 },
                    new Track { IdTrack = 2, TrackName = "Molesta", Duration = 10, IdMusicAlbum = 2 }
                    );
            });

            modelBuilder.Entity<Album>(p =>
            {
                p.HasData(
                    new Album { IdAlbum = 1, AlbumName = "Dookola swiata", PublishDate=System.DateTime.UtcNow, IdMusicLabel = 1},
                    new Album { IdAlbum = 2, AlbumName = "Kury kurczaki", PublishDate=System.DateTime.UtcNow, IdMusicLabel = 2}
                    );
            });

            modelBuilder.Entity<MusicLabel>(p =>
            {
                p.HasData(
                    new MusicLabel { IdMusicLabel = 1, Name = "Pejastola" },
                    new MusicLabel { IdMusicLabel = 2, Name = "Hakulki" }
                    );
            });
        }


    }
}
