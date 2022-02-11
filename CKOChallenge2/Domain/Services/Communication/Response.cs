using CKOChallenge2.Dtos;

namespace CKOChallenge2.Domain.Services.Communication;

public class Response : BaseResponse
{
    public Request Request { get; private set; }

    private Response(bool success, string message, Request request) : base(success, message)
    {
        Request = request;
    }

    /// <summary>
    /// Creates am error response.
    /// </summary>
    /// <param name="message">Error message.</param>
    /// <returns>Response.</returns>
    public Response(string message) : this(false, message, null)
    {
    }
}