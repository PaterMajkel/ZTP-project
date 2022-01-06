using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class Level
    {
        [Key]
        public int LvlNumber { get; set; }
        public string LvlAssets { get; set; }
        public string LvlEnemies { get; set; }
        public ICollection<ScoreBoard> ScoreBoards { get; set; }
    }
}
