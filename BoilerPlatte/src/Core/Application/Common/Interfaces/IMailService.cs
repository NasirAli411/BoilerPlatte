using BoilerPlatte.Shared.DTOs.General.Requests;

namespace BoilerPlatte.Application.Common.Interfaces;

public interface IMailService : ITransientService
{
    Task SendAsync(MailRequest request);
}
