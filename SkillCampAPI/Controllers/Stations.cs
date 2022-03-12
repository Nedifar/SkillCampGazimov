using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Stations : ControllerBase
    {
        Models.context context;
        public Stations(Models.context _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Models.GasStation>>> getGasStation(string fuel)
        {
            var list = await context.GasStations.Include(p=>p.CarFillingStations).ToListAsync();
            return list.Where(p => p.CarFillingStations.Any(x => x.Name == fuel)).ToList();
        }

        [HttpPost]
        public async Task<ActionResult> postGasStation(Models.GasStation gasStation)
        {
            try
            {
                var gas = context.GasStations.Where(p => p.idStation == gasStation.idStation).FirstOrDefault();
                if (gas != null)
                context.CarFillingStations.UpdateRange(gasStation.CarFillingStations);
                else
                    context.GasStations.Add(gasStation);
                context.SaveChanges();
            }
            catch { }
            return Ok();
        }

        [HttpGet("getStationInfo")]
        public async Task<ActionResult<Models.GasStation>> getStationInfo(int id)
        {
            return context.GasStations.Where(p => p.idStation == id).FirstOrDefault();
        }

        [HttpGet("getLoaylityBalance/{loal}")]
        public async Task<ActionResult<Models.LoyaltyCard>> getLoality(string loal)
        {
            loal = loal.ToUpper();
            var l = context.LoyaltyCards.Where(p => p.CardHolder == loal).FirstOrDefault();
            return l;
        }

        [HttpPost("getLoaylityBalanceModify")]
        public async Task<ActionResult<Models.LoyaltyCard>> postLoality(Models.LoyaltyCard loal)
        {
            context.LoyaltyCards.Update(loal);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("getDepositBalance")]
        public async Task<ActionResult<Models.DepositCard>> getDepositCard(string loal)
        {
            loal = loal.ToUpper();
            var l = context.DepositCards.Where(p => p.CardHolder == loal).FirstOrDefault();
            return l;
        }

        [HttpPost("getDepositBalanceModify")]
        public async Task<ActionResult<Models.DepositCard>> postdeposite(Models.DepositCard loal)
        {
            context.DepositCards.Update(loal);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost("pay")]
        public async Task<ActionResult<string>> postPay(Models.Pay pay)
        {
            context.Pays.Add(pay);
            context.SaveChanges();
            return Ok($"Одобрено. Код транзакции: {DateTime.Now.ToString("ddMMyyyy-hhmmss")}");
        }

        [HttpPost("purchase")]
        public async Task<ActionResult<string>> postPurchase(Models.Purchase pay)
        {
            context.Purchases.Add(pay);
            context.SaveChanges();
            return Ok();
        }

        [HttpPost("refund")]
        public async Task<ActionResult> postRefuend(Models.Refund refeund)
        {
            context.Refunds.Add(refeund);
            context.SaveChanges();
            return Ok();
        }
    }
}
