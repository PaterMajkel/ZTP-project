using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class ScoreBoard
    {
        [Key]
        public int ScoreBoardId { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        [ForeignKey("Level")]
        public int LevelNumber { get; set; }
        public Level Level { get; set; }
    }
}
