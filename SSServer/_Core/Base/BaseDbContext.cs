using Microsoft.EntityFrameworkCore;

namespace SSServer._Core.Base
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
