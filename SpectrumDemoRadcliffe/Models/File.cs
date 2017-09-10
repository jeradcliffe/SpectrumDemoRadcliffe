using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpectrumDemoRadcliffe.Models
{
    public class File
    {
        public int FileId { get; set; }

        public int PersonId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Content type can't be longer than 50 characters.")]
        public string ContentType { get; set; }

        public byte[] Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        public int NoDownloads { get; set; }

        public virtual Person Person { get; set; }
    }
}
