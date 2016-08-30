using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public byte[] ImageData { get; set; }

        [Required]
        public Post Post { get; set; }        
    }
}