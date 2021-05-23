using System;
using System.Threading.Tasks;


namespace R5T.D0069
{
    public interface IApplicationNameProvider
    {
        Task<string> GetApplicationName();
    }
}
