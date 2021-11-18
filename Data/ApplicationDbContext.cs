namespace DockerMySql.Data;

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Location> Locations { get; set; }
}
