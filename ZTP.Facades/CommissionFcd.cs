using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.Interfaces.Infrastructure;

namespace ZTP.Interfaces.Facades
{
    public class CommissionFcd : ICommissionFcd
    {
        private readonly ICommissionService _commissionService;
        private readonly IMapper _mapper;

        public CommissionFcd(ICommissionService commissionService, IMapper mapper)
         => (_commissionService, _mapper) = (commissionService, mapper);
        public ICollection<CommissionDTO> GetAllCommissions()
        {
            return _commissionService.GetCommissions();
        }
    }
}
