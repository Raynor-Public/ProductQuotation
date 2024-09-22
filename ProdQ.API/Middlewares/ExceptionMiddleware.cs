using Newtonsoft.Json;
using System.Net;

namespace ProdQ.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) 
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode statusCode;
            string result;

            switch (exception)
            {
                case ArgumentNullException ex:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonConvert.SerializeObject(new { error = "A required argument was null" });
                    break;
                case UnauthorizedAccessException ex:
                    statusCode = HttpStatusCode.Unauthorized;
                    result = JsonConvert.SerializeObject(new { error = "Unauthorized access" });
                    break;
                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    result = JsonConvert.SerializeObject(new { error = "An unexpected error occurred" });
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            return context.Response.WriteAsync(result);
        }

    }
}
