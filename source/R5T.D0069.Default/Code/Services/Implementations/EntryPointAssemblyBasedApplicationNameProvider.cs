using System;
using System.Reflection;
using System.Threading.Tasks;


namespace R5T.D0069
{
    /// <summary>
    /// Provides the application name from the name of the entry-point assembly. This is the same as the default behavior for IHostEnvironment described here: https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.hosting.ihostingenvironment.applicationname?view=aspnetcore-5.0
    /// </summary>
    public class EntryPointAssemblyBasedApplicationNameProvider : IApplicationNameProvider
    {
        public Task<string> GetApplicationName()
        {
            var entryPointAssembly = Assembly.GetEntryAssembly();

            var entryPointAssemblyName = entryPointAssembly.GetName();

            return Task.FromResult(entryPointAssemblyName.Name);
        }
    }
}
