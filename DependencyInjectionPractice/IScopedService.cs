using System;

namespace DependencyInjectionPractice
{
    public interface IScopedService
    {
        Guid GetOperationID();
    }
}
