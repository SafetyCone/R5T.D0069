using System;
using System.Reflection;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0069
{
    /// <summary>
    /// Provides the application name from the name of the entry-point assembly. This is the same as the default behavior for IHostEnvironment described here: https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.hosting.ihostingenvironment.applicationname?view=aspnetcore-5.0
    /// </summary>
    [ServiceImplementationMarker]
    public class EntryPointAssemblyBasedApplicationNameProvider : IApplicationNameProvider, IServiceImplementation
    {
        public Task<string> GetApplicationName()
        {
            var entryPointAssembly = Assembly.GetEntryAssembly();

            var entryPointAssemblyName = entryPointAssembly.GetName();

            return Task.FromResult(entryPointAssemblyName.Name);
        }
    }
}
