using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ZTP.Interfaces.Facades;

namespace ZTP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommissionController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ICommissionFcd _commissionFcd;

        public CommissionController(ILogger<UserController> logger,
            ICommissionFcd commissionFcd)
        {
            _logger = logger;
            _commissionFcd = commissionFcd;
        }

        [HttpGet("GetAllCommissions")]
        public  ActionResult GetAllCommissions()
        {
            var data = _commissionFcd.GetAllCommissions();
            return (data != null) ? Ok(data) : NotFound("Nie udalo zdobyć danych");
        }
    }

}