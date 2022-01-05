using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.Common.DTO
{
    public class CommissionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Localization { get; set; }
        public int MakerId { get; set; }
        //TODO: Will be required in the future (it's already not nullable but still)        public UserInfoDTO ComissionMaker { get; set; }
        public int? TakerId { get; set; }
        public UserInfoDTO ComissionTaker { get; set; }
    }
}
