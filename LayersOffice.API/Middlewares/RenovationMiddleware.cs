using Microsoft.AspNetCore.Http;

namespace LayersOffice.API.Middlewares
{
    public class RenovationMiddleware
    {
        private readonly RequestDelegate _next;
        public RenovationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var time = DateTime.Now;
            if(time.Day == 30 || time.Day == 31)
            {
                await context.Response.WriteAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Content = new StringContent("ERROR message: the site is under renovation, try again tomorrow")
                }.ToString());
            }
            else
                await _next(context);
        }
    }
}
