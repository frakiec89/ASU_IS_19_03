using ASU_IS_19_03.DB.Model;
using Microsoft.EntityFrameworkCore;

namespace ASU_IS_19_03.DB
{
    class MsSqlContext : DbContext
    {
        string connect = 
            
          "Server=192.168.10.134;Database=MsSqlContext_Ahtyamov_IS_19_03;user=stud;password=stud";

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<PrinterSklad> PrinterSklads { get; set; }
        public DbSet<Sklad> Sklads { get; set; }
        public DbSet<TypePrinter> TypePrinters { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(connect);
        }
    }
}
