using System;
using System.Collections.Generic;

namespace przedKolokwium1.Models.DTO
{
    public class SomeSortOfAlbum
    {
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public IEnumerable<string> TrackList { get; set; }
    }
}
