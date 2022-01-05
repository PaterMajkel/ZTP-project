using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public int? Adress { get; set; }
        //Do ustalenia, czy może mieć więcej preferencji
        public string TypeOfHouse { get; set; }
        public int? AvatarId { get; set; }
        public Avatar Avatar { get; set; }
        public ICollection<Commission> Comissions { get; set; }
    }
}
