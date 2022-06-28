namespace Todo.Data
{
    public class AppDbContext : AppDbContext
    {
        public int DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app;Cache=Shared");
    }
}