using BoilerPlatte.Application.Exceptions;
using System.Net;

namespace BoilerPlatte.Application.Multitenancy;

public class InvalidTenantException : CustomException
{
    public InvalidTenantException(string message)
    : base(message, null, HttpStatusCode.BadRequest)
    {
    }
}
