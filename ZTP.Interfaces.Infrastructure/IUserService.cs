using System;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Infrastructure
{
    public interface IUserService
    {
        Task<AppUserDTO> GetCurrentUser();
        Task<AppUserDTO> GetUserById(string id);
        Task<ServerResponseDTO> CreateNewUser(AppUserDTO user, string password);
        Task<ServerResponseDTO> Login(string login, string password);
        Task<UserInfoDTO> GetUserInfo(string id);

    }
}
