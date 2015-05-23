using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UglyMuttSite.Models
{
    public class Images
    {
        //properties
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        //TODO: add in postid, projectId as foreign keys
    }
}