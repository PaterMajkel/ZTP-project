using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Common.DTO
{
    public class UserInfoDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public int? Adress { get; set; }
        public string TypeOfHouse { get; set; }
        public int? AvatarId { get; set; }
        //Może powinno się dodać zlecenia, ale chyba wygodniej je ładować, kiedy są potrzebne, a potem je zacachować
    }
}
