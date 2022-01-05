using System;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Facades
{
    public interface IUserFcd
    {
        Task<ServerResponseDTO> Login(string login, string password);
        Task<ServerResponseDTO> Register(AppUserDTO user, string password);
        Task<UserInfoDTO> getUserInfo(string id);

    }
}
