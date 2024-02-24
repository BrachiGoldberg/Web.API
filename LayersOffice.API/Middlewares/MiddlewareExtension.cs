namespace LayersOffice.API.Middlewares
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder RenovationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RenovationMiddleware>();
        }

        public static IApplicationBuilder LoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }
    }
}
