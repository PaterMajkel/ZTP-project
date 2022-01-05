using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP.EntityFramework.Models
{
    public class Avatar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] Image { get; set; }
    }
}
