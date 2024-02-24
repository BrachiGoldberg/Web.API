namespace LayersOffice.API.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly ILogger<LoggerMiddleware> _logger;
        private readonly RequestDelegate _next;

        public LoggerMiddleware(ILogger<LoggerMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var requestSeq = Guid.NewGuid().ToString();
            _logger.LogInformation($"Request Starts {requestSeq}");
            context.Items.Add("RequestSequence", requestSeq);
            await _next(context);
            _logger.LogInformation($"Request Ends {requestSeq}");
        }
    }
}
