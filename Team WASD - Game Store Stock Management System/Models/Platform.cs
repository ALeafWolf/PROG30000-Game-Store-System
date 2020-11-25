using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    [Table("tblPlatform")]
    public class Platform
    {
        [Key]
        public int PlatformId { get; set; }
        public string PlatformName { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}