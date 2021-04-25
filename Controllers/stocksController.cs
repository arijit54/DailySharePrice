using DailySharePrice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class stocksController : ControllerBase
    {
        private IInMemoryStockDb stockDbObj;
        public stocksController(IInMemoryStockDb obj)
        {
            stockDbObj = obj;
        }
        [HttpGet]
        public ActionResult<InMemoryStockDb> GetStocks()
        {
            var temp = new List<dynamic>();
            foreach(var x in InMemoryStockDb.dailyStockDetails)
            {
                x.ToString();
                temp.Add(x);
                
            }
            if (temp != null)
                return Ok(temp);
            else
                return BadRequest();
        }
    }
}
