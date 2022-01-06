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
    [Route("[GameController]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IGameFcd _gameFcd;

        public UserController(ILogger<UserController> logger,
            IGameFcd gameFcd)
        {
            _logger = logger;
            _gameFcd = gameFcd;
        }
        [HttpGet("GetLevel")]
       public LevelDTO GetLevel(int levelId)
        {
            return _gameFcd.GetLevel(levelId);
        }
        [HttpGet("GetAllLevels")]
        public ICollection<LevelDTO> GetAllLevels()
        {
            return _gameFcd.GetAllLevels();
        }
        [HttpPost("PostScore")]
        public void PostScore(ScoreBoardDTO scoreBoardDTO, int levelId)
        {
           _gameFcd.PostScore(scoreBoardDTO, levelId);
        }
    }
}
