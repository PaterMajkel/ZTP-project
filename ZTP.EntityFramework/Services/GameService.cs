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


        public ICollection<ScoreBoardDTO> GetAllScores()
        {
            var scores = _context.ScoreBoards.ToList();
            return _mapper.Map<ICollection<ScoreBoardDTO>>(scores);
        }

        public ICollection<LevelDTO> GetAllLevels()
        {
            var levels = _context.Levels.ToList();
            if (levels == null)
                return null;
            return _mapper.Map<ICollection<LevelDTO>>(levels);
        }

        public ScoreBoardDTO PostScore(ScoreBoardDTO scoreBoardDTO)
        {
            _context.ScoreBoards.Add(new Models.ScoreBoard { Name = scoreBoardDTO.Name, Score = scoreBoardDTO.Score });
            _context.SaveChanges();
            return _mapper.Map<ScoreBoardDTO>(_context.ScoreBoards.Where(p=>p.Name==scoreBoardDTO.Name && p.Score==scoreBoardDTO.Score).FirstOrDefault());
        }

    }
}
