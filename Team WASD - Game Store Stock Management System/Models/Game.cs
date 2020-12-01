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

        public Publisher Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Platform Platform { get; set; }

        public Genre Genre { get; set; }

        public string Description { get; set; }

        public int InStockAmount { get; set; }

        public double Price { get; set; }




    }
}