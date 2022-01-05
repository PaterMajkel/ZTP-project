using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class AppUser : IdentityUser
    {
        //Do przechowywania większej ilości informacji -> do ustalenia, czy jedno konto może mieć parę profili
        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
    }
}
