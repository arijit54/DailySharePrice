using DailySharePrice.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DailySharePrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailySharePriceController : ControllerBase
    {
        private IInMemoryStockDb stockDbObj;

        public DailySharePriceController(IInMemoryStockDb obj)
        {
            stockDbObj = obj;
        }

        // GET: api/<DailySharePriceController>
        [HttpGet("{stockName}")]
        public ActionResult Get(string stockName)
        {
            if (stockName == null)
            {
                return BadRequest();
            }


            var obj = stockDbObj.DailySharePrice(stockName);
            if (obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);
        }
       
       

        }

        
        
    }

