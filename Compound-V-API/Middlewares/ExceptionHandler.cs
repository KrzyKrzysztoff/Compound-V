using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Compound_V_API.Middlewares
{
    public class ExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = 500;

            httpContext.Response.ContentType = Text.Html;

            await httpContext.Response.WriteAsync("<p>An error has occured</p>");

            return true;
        }
    }
}
