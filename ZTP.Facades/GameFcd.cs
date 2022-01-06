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
            var levelDTOs = _gameService.getAllLevels();
            if (levelDTOs == null)
                return null;
            foreach(var levelDTO in levelDTOs)
            {
                levelDTO.ScoreBoardDTOs = _gameService.GetScoreBoardsOfLevel(levelDTO.LvlNumber);
            }

            return levelDTOs;
        }

        public LevelDTO GetLevel(int levelId)
        {
            var levelDTO = _gameService.GetLevel(levelId);
            if (levelDTO == null)
                return null;

            levelDTO.ScoreBoardDTOs = _gameService.GetScoreBoardsOfLevel(levelDTO.LvlNumber);

            return levelDTO;
        }

        public void PostScore(ScoreBoardDTO scoreBoardDTO, int levelId)
        {
            _gameService.PostScore(scoreBoardDTO, levelId);
        }
    }
}
