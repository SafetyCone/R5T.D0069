﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0069
{
    [ServiceDefinitionMarker]
    public interface IApplicationNameProvider : IServiceDefinition
    {
        Task<string> GetApplicationName();
    }
}
