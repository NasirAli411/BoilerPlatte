using BoilerPlatte.Application.Common.Interfaces;
using System.ComponentModel;

namespace BoilerPlatte.Application.Patient.Interfaces;

public interface IContactGeneratorJob : IScopedService
{
    [DisplayName("Generate Random contact example job on Queue notDefault")]
    Task GenerateAsync(int nSeed);

    [DisplayName("removes all radom contacts created example job on Queue notDefault")]
    Task CleanAsync();
}
