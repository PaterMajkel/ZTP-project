using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Infrastructure
{
    public interface ICommissionService
    {
        ICollection<CommissionDTO> GetCommissions();
    }
}
