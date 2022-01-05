using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Common.DTO
{
    public class ServerResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public ServerResponseDTO(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
