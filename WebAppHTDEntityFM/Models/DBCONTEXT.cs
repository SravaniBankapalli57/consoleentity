using Microsoft.EntityFrameworkCore;
namespace WebAppHTDEntityFM.Models
{
    public class DBCONTEXT:DbContext
    {
        public DBCONTEXT()
        {

        }
        public DBCONTEXT(DbContextOptions<DBCONTEXT> options) : base(options)
        {

        }
        public virtual DbSet<PRODUCTMODEL> PRODUCT{ get; set; }
        public virtual DbSet<STUDENT> SSTUDENT { get; set; }
        public virtual DbSet<ITEMS> SITEMS { get; set; }
        public virtual DbSet<ORDERS> SORDERS { get; set; }
        public virtual DbSet<EMPLOY> SEMPLOY { get; set; }
        public virtual DbSet<COUNTRY> Country { get; set; }
        public virtual DbSet<STATE> State { get; set; }
        public virtual DbSet<STUD> student { get; set; }
        public virtual DbSet<DEP> deptartment { get; set; }
        public virtual DbSet<SFEE> studentfee { get; set; }
    }
}
