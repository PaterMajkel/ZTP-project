using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.Interfaces.Facades;

namespace ZTP.Controllers
{
    [ApiController]
    [Route("API/GameController")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameFcd _gameFcd;

        public GameController(ILogger<GameController> logger,
            IGameFcd gameFcd)
        {
            _logger = logger;
            _gameFcd = gameFcd;
        }
        [HttpGet("GetAllLevels")]
        public ICollection<LevelDTO> GetAllLevels()
        {
            return _gameFcd.GetAllLevels();
        }
        [HttpGet("GetAllScores")]
        public ICollection<ScoreBoardDTO> GetAllScores()
        {
            return _gameFcd.GetAllScores();
        }
        [HttpPost("PostScore")]
        public void PostScore(ScoreBoardDTO scoreBoardDTO)
        {
            _gameFcd.PostScore(scoreBoardDTO);
        }
    }
}
