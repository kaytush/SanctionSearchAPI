using Microsoft.EntityFrameworkCore;
using SanctionSearchAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using WashingtonStudents.Web.Api.Models;

namespace SanctionSearchAPI.Data
{
    public class WSDataContextBroker :  DbContext
    {
        public WSDataContextBroker(DbContextOptions<WSDataContextBroker> options) : base(options)
        {

        }

        public DbSet<LocalWatchlist> LocalWatchlists { get; set; }

        [DbFunction(FunctionName = "SOUNDEX", Schema = "")]
        public static string SoundsLike(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
