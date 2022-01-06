using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.EntityFramework.Models;

namespace ZTP.EntityFramework
{
    public class EFDBMapperProfile : AutoMapper.Profile
    {
        public EFDBMapperProfile()
        {

            CreateMap<LevelDTO, Level>().ReverseMap();
            CreateMap<ScoreBoard, ScoreBoardDTO>().ReverseMap();
        
        }
    }
}
