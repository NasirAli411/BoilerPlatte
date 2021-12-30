using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Domain.Common;
using BoilerPlatte.Shared.DTOs.Storage;

namespace BoilerPlatte.Application.Storage;

public interface IFileStorageService : ITransientService
{
    public Task<string> UploadAsync<T>(FileUploadRequest request, FileType supportedFileType)
    where T : class;
}
