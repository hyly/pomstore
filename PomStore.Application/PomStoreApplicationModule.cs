using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace PomStore
{
    [DependsOn(typeof(PomStoreCoreModule), typeof(AbpAutoMapperModule))]
    public class PomStoreApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
