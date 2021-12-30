using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs;

namespace BoilerPlatte.Application.Dashboard;

public interface IStatsService : ITransientService
{
    Task<IResult<StatsDto>> GetDataAsync();
}
