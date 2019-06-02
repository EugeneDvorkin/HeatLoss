using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HeatLoss.Service.Common;
using HeatLoss.Service.Common.Entity;
using HeatLoss.Service.Common.IService;

namespace WebApplication1.Controllers
{
    [RoutePrefix("heat")]
    public class HeatLossController : ApiController
    {
        private readonly IHeatLoosCalculation _heatService;

        public HeatLossController(IHeatLoosCalculation heatService)
        {
            _heatService = heatService ?? throw new ArgumentNullException($"{nameof(heatService)} is null");
        }

        // GET api/values/5
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetResultAsync([FromBody]StartParams startParams)
        {
            try
            {
                var result = await _heatService.CalculateArea(startParams);
                return Ok(result);
            }
            catch (BllException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
