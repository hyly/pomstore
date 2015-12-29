using PomStore.EntityFramework;
using EntityFramework.DynamicFilters;

namespace PomStore.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly PomStoreDbContext _context;

        public InitialDataBuilder(PomStoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.DisableAllFilters();

            new DefaultEditionsBuilder(_context).Build();
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
