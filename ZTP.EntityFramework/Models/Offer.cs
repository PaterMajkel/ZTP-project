using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //Twórca oferty - inna nazwa, by nie niszczyć ustaleń języka na ten moment -> do zmiany, po ogarnięciu
        public int UserInfoId { get; set; }
        public UserInfo User { get; set; }
        public int CommissionId { get; set; }

        public Commission Commission { get; set; }

    }
}
