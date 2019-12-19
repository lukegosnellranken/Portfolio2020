using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecordStoreProject.Models
{
    public class GenreMetadata
    {
        [StringLength(50)]
        [Required(ErrorMessage = "A Genre is required")]
        [Display(Name = "Genre Name")]
        public string GenreName;
    }

    public class ArtistMetadata
    {
        [StringLength(100)]
        [Required(ErrorMessage = "An Artist Name is required")]
        [Display(Name = "Artist Name")]
        public string ArtistName;
    }

    public class AlbumMetadata
    {
        [StringLength(50)]
        [Required(ErrorMessage = "An Album Name is required")]
        [Display(Name = "Album Name")]
        public string AlbumName;

        [Range(1, 100, ErrorMessage = "Album Price must be between 1 and 100")]
        [Display(Name = "Album Price")]

        public decimal AlbumPrice;
    }
}