
namespace MiddlewareProgram
{
    public class Class1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware Incomming Request");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware Outcomming Response");
        }
    }
}
