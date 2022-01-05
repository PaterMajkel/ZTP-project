using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class Commission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Localization { get; set; }
        public int MakerId { get; set; }
        //TODO: will be required in the future (i mean it is not nullable already but still)
        public UserInfo ComissionMaker { get; set; }
        public int? TakerId { get; set; }
        public UserInfo ComissionTaker { get; set; }
        
    }
}
