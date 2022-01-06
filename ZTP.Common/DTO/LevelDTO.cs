using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Common.DTO
{
    public class LevelDTO
    {
        public int LvlNumber { get; set; }
        public string LvlAssets { get; set; }
        public string LvlEnemies { get; set; }
        public ICollection<ScoreBoardDTO> ScoreBoardDTOs { get; set; }
    }
}
