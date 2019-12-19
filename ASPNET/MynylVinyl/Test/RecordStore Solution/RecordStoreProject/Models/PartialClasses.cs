using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordStoreProject.Models
{
    [MetadataType(typeof(GenreMetadata))]
    public partial class Genre
    {
    }

    [MetadataType(typeof(ArtistMetadata))]
    public partial class Artist
    {
    }

    [MetadataType(typeof(AlbumMetadata))]
    public partial class Album
    {
    }
}