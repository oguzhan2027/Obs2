using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-AB0HGN7;initial catalog=CasgemObsYeni;integrated security=true");
        }
       
        public DbSet<Bolum> Bolums { get; set; }
        public DbSet<Ders> Derses { get; set; }
      
        
        public DbSet<Fakulte> Fakultes { get; set; }
        
        public DbSet<Ogrenci> Ogrencis { get; set; }

        public DbSet<Ogretmen> Ogretmens { get; set; }
        public DbSet<Login> Logins { get; set; }
       public DbSet<DersListesi> DersListesi { get; set;}
        public DbSet<Devamsızlık> Devamsızlıks { get; set; }
        public DbSet<Not> Nots { get; set; }
    }
}
