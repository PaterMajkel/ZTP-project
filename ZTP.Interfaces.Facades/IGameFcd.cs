using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Facades
{
    public interface IGameFcd
    {
        LevelDTO GetLevel(int levelId);

        ICollection<LevelDTO> GetAllLevels();

        void PostScore(ScoreBoardDTO scoreBoardDTO, int levelId);
    }
}
