using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.EntityFramework.Models;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.EntityFramework.Services
{
    public class UserService : IUserService
    {
        private readonly EFDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;
        private static HttpContext _httpContext => new HttpContextAccessor().HttpContext;

        public UserService(EFDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IMapper mapper)
            => (_context, _userManager, _signInManager, _mapper) = (context, userManager, signInManager, mapper);

        public async Task<ServerResponseDTO> CreateNewUser(AppUserDTO user, string password)
        {
            UserInfo User = new UserInfo { };
            _context.UserInfos.Add(User);
            var newUser = new AppUser { Email = user.UserEmail, UserName = user.UserLogin, UserInfo=User };
            var result = await _userManager.CreateAsync(newUser, password);
            _context.SaveChanges();
            if(result.Succeeded)
            {
                _context.Users.Find(newUser.Id).EmailConfirmed = true;
                return new ServerResponseDTO(true, "Poszlo!");
            }
            return new ServerResponseDTO(false, $"Cos poszlo nie tak! {user.UserEmail} {user.UserLogin}");


        }

        public async Task<AppUserDTO> GetCurrentUser()
        {
            var user = _httpContext.User.Identity;
            var claims = _httpContext.User.Claims;

            var userId = claims.First(x => x.Type == ClaimTypes.PrimarySid).Value;

            var currentUser = await _userManager.FindByIdAsync(userId);
            

            var existingUserRole = (await _userManager.GetRolesAsync(currentUser)).First();
            var existingUserDTO = _mapper.Map<AppUserDTO>(currentUser);

            return existingUserDTO;
        }

        public async Task<AppUserDTO> GetUserById(string id) =>
            _mapper.Map<AppUserDTO>(await _userManager.FindByIdAsync(id));
        
        public async Task<ServerResponseDTO> Login(string login, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(login, password, false, false);

            if (result.Succeeded)
                return new ServerResponseDTO(true, "Poszlo!");
            return new ServerResponseDTO(false, "Cos poszlo nie tak!");

        }

        public async Task<UserInfoDTO> GetUserInfo(string id)
        {

            var UserToGetInfoFrom = await _userManager.FindByIdAsync(id);
            var x = _context.UserInfos.Find(UserToGetInfoFrom.UserInfoId);
            //var LinkedTable = _context..
            if (UserToGetInfoFrom == null)
                return null;
            return _mapper.Map<UserInfoDTO>(_context.UserInfos.Find(UserToGetInfoFrom.UserInfoId));
        }
    }
}
