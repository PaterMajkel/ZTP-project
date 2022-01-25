using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Infrastructure
{
    public interface IGameService
    {

        ICollection<LevelDTO> GetAllLevels();

        ICollection<ScoreBoardDTO> GetAllScores();

        ScoreBoardDTO PostScore(ScoreBoardDTO scoreBoardDTO);

    }
}
