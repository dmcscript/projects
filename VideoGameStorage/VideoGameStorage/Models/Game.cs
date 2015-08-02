using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameStorage.Models
{
    public class Game
    {
        [Key] public int GameID { get; set; }
        [Required] public string name{ get; set; }
        public string rating { get; set; }
        [Required]
        [ForeignKey("GameSystem")]
        public int SystemID { get; set; }
        public virtual GameSystem GameSystem { get; set; }
    }

    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public System.Data.Entity.DbSet<VideoGameStorage.Models.GameSystem> GameSystems { get; set; }
    }
}