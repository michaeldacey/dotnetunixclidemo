using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculatorlib;

namespace calculatorapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
		private ICalculatorAPI _service;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculatorAPI service)
        {
            _logger = logger;
			_service = service;
        }

        [HttpGet("/api/calculator")]
        public ActionResult<int> GetValue()
        {
			return _service.GetValue();
        }
		
        [HttpPost("/api/calculator")]
        public ActionResult<Result> PostNumber(int number)
        {
			return _service.AddNumber(number);
        }

        [HttpPut("/api/calculator/{number}")]
        public ActionResult<Result> PutNumber(int number)
        {
			return _service.AddNumber(number);
        }		
    }
}
