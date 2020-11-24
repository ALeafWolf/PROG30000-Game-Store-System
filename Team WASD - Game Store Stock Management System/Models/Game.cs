using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Team_WASD___Game_Store_Stock_Management_System.Models
{
    [Table("tblGame")]
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string GameTitle { get; set; }
    }
}