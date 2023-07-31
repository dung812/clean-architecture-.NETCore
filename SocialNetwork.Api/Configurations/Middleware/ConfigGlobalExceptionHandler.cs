namespace SocialNetwork.Api.Configurations.Middleware
{
    public static class ConfigGlobalExceptionHandler
    {
        public static void UseGlobalExceptionHandler(this WebApplication app)
        {
            app.UseMiddleware<GlobalExceptionHandler>();
        }
    }
}
