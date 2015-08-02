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
    public class GameSystem
    {
        [Key]  public int SystemID { get; set; }
        [Required][Display(Name="Console")] public string Name { get; set; }
        public int Num_Games { get; set; }


        public virtual ICollection<Game> Games { get; set; }
    }

    public class GameSystemContext : DbContext
    {
            public DbSet<GameSystem> Systems{ get;set; }

        public System.Data.Entity.DbSet<VideoGameStorage.Models.Game> Games { get; set; }
    }
}