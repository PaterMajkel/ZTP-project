using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTP.Common.DTO;
using ZTP.Interfaces.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace ZTP.EntityFramework.Services
{
    public class CommissionService : ICommissionService
    {
        private EFDbContext _context;
        private readonly IMapper _mapper;
        private static HttpContext _httpContext => new HttpContextAccessor().HttpContext;

        public CommissionService(EFDbContext context,
            IMapper mapper)
            => (_context, _mapper) = (context, mapper);

        public ICollection<CommissionDTO> GetCommissions()
        {
            //Nie wiem dlaczego nie mogę użyć include w tym kontekście //TODO research
            /*return null;
            var commissions = _context.Commissions;
            var commisionUsers = new List<CommissionDTO>();
            foreach (var commission in commissions)
            {
                var temp = commission.Include
            }*/
            var x = _context.Commissions.Include(p => p.ComissionMaker).Include(p => p.ComissionTaker).ToList();
            return _mapper.Map<CommissionDTO[]>(x);
        }
    }
}
