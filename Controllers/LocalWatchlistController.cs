using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanctionSearchAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanctionSearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalWatchlist : ControllerBase
    {
        private readonly WSDataContextBroker _context;

        public LocalWatchlist(WSDataContextBroker context)
        {
            _context = context;
        }

        // GET: api/localWatchlist/searchkeyword
        [HttpGet("{searchkeyword}")]
        //public async Task<ActionResult<LocalWatchlist>> GetLocalWatchlist(string searchkeyword)
        public async Task<IActionResult> GetLocalWatchlist(string searchkeyword)
        {
            var localWatchlist = await _context.LocalWatchlists.Where(a =>
                WSDataContextBroker.SoundsLike(a.last_name) == WSDataContextBroker.SoundsLike(searchkeyword) ||
                WSDataContextBroker.SoundsLike(a.first_name) == WSDataContextBroker.SoundsLike(searchkeyword))
                .ToListAsync();

            if (localWatchlist == null)
            {
                return NotFound();
            }
           return Ok(localWatchlist);


        }

       
    }
           
}

