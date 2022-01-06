using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.EntityFramework.Services
{
    public class GameService : IGameService
    {
        private readonly EFDbContext _context;
        private readonly IMapper _mapper;
        private static HttpContext _httpContext => new HttpContextAccessor().HttpContext;

        public GameService(EFDbContext context,
            IMapper mapper)
            => (_context, _mapper) = (context, mapper);

        public ICollection<ScoreBoardDTO> GetScoreBoardsOfLevel(int levelId)
        {
            var level = _context.Levels.Where(p => p.LvlNumber == levelId).Include(p=> p.ScoreBoards).First();
            if (level == null)
                return null;
            return _mapper.Map<ICollection<ScoreBoardDTO>>(level.ScoreBoards);
        }

        public LevelDTO GetLevel(int levelId)
        {
            var level = _context.Levels.Where(p => p.LvlNumber == levelId).First();
            if (level == null)
                return null;
            return _mapper.Map<LevelDTO>(level);
        }

        public ICollection<LevelDTO> getAllLevels()
        {
            var levels = _context.Levels.ToList();
            if (levels == null)
                return null;
            return _mapper.Map<ICollection<LevelDTO>>(levels);
        }

        public void PostScore(ScoreBoardDTO scoreBoardDTO, int levelId)
        {
            _context.ScoreBoards.Add(new Models.ScoreBoard { LevelNumber = levelId, Name=scoreBoardDTO.Name, Score=scoreBoardDTO.Score });
            _context.SaveChanges();
        }

    }
}
