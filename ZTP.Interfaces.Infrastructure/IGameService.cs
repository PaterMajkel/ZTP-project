using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Infrastructure
{
    public interface IGameService
    {
        ICollection<ScoreBoardDTO> GetScoreBoardsOfLevel(int levelId);

        LevelDTO GetLevel(int levelId);

        ICollection<LevelDTO> getAllLevels();

        void PostScore(ScoreBoardDTO scoreBoardDTO, int levelId);

    }
}
