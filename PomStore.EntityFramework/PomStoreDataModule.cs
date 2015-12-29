using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using PomStore.EntityFramework;

namespace PomStore
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(PomStoreCoreModule))]
    public class PomStoreDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
