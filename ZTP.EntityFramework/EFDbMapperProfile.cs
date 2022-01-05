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

            CreateMap<AppUser, AppUserDTO>().ReverseMap();
            CreateMap<AppRole, RoleDTO>().ReverseMap();

            CreateMap<UserInfo, UserInfoDTO>().ReverseMap();
            CreateMap<Commission, CommissionDTO>().ReverseMap();

        }
    }
}
