using Microsoft.EntityFrameworkCore;

namespace U1
{
    class Contexto:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UQ0K52S\\SQLEXPRESS;Integrated Security=SSPI;Initial catalog=Alkemy");
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Posts> Postss { get; set; }

}
}
