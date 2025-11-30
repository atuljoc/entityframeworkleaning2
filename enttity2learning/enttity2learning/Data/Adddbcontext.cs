using Microsoft.EntityFrameworkCore;

namespace enttity2learning.Data
{
    public class Adddbcontext :DbContext
    {
        public Adddbcontext(DbContextOptions<Adddbcontext> options) : base(options)
        { 

        }

    }
}
