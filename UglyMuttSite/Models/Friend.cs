using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UglyMuttSite.Models
{
    public class Friend
    {
        //properties
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FriendId { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        //TODO: make foreign key for images because it only has one picture
    }
}