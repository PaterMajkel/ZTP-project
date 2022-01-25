using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.EntityFramework.Models;
using ZTP.Interfaces.Facades;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.Facades
{
    public class GameFcd : IGameFcd
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public GameFcd(IGameService gameService, IMapper mapper)
         => (_gameService, _mapper) = (gameService, mapper);

        public ICollection<LevelDTO> GetAllLevels()
        {
            var levels = _gameService.GetAllLevels();

            return levels;
        }

        public ICollection<ScoreBoardDTO> GetAllScores()
        {
            var scores = _gameService.GetAllScores();

            return scores;
        }


        public ScoreBoardDTO PostScore(ScoreBoardDTO scoreBoardDTO)
        {
            return _gameService.PostScore(scoreBoardDTO);
        }
    }
}
