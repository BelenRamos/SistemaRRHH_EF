using Microsoft.EntityFrameworkCore;

namespace _2.AccesoDatos
{
    public class rrhhContext : DbContext
    {
        public rrhhContext(DbContextOptions<rrhhContext> options) 
            :base(options)
        {
        }
    }
}