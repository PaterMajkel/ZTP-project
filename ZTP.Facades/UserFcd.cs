using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.EntityFramework.Models;
using ZTP.Interfaces.Facades;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.Facades
{
    public class UserFcd : IUserFcd
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;

        public UserFcd(IUserService userService, IMapper mapper)
         => (_userService, _mapper) = (userService, mapper);

        public UserFcd(IUserService userService, IMapper mapper, SignInManager<AppUser> signInManager)
         => (_userService, _signInManager, _mapper) = (userService, signInManager, mapper);

        public async Task<ServerResponseDTO> Login(string login, string password)
        {
            return await _userService.Login(login, password);
        }

        public async Task<ServerResponseDTO> Register(AppUserDTO user, string password)
        {
            return await _userService.CreateNewUser(user, password);
        }
        public  async Task<UserInfoDTO> getUserInfo(string id)
        {
            return await _userService.GetUserInfo(id);
        }
    }
}
