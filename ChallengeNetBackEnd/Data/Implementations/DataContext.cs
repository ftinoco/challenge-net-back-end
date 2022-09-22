using ChallengeNetBackEnd.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNetBackEnd.Data.Implementations
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options)
            : base(options) { }

    }
}
