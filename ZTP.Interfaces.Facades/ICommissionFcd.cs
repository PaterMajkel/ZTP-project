using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;

namespace ZTP.Interfaces.Facades
{
    public interface ICommissionFcd
    {
        ICollection<CommissionDTO> GetAllCommissions();
    }
}
