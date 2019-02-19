using Core.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace CleanGuestbookMvc5.DependencyResolution {
	
    public class DefaultRegistry : Registry {
        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.AssemblyContainingType<IGuestbookRepository>(); // Core
                    scan.AssemblyContainingType<ILogger>(); // Core
                    scan.Assembly("Infrastructure"); // the Infrastructure DLL
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                    scan.LookForRegistries(); // find and run other registries
                });
        }
    }
}