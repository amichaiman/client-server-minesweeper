using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDB
{
    class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public System.DateTime GameDate { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public bool Tie { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
