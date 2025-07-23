namespace OnionArchitecture.WebApi.Configurations
{
    public static class ScalarApiConfiguration
    {
        public static void ScalarApiRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("Scalar");
            bool openUI = config.GetValue<bool>("OpenScalarUIOnStart");
            string routePrefix = config.GetValue<string>("RoutePrefix") ?? "scalar";
            string appUrl = configuration["ASPNETCORE_URLS"] ?? "http://localhost:7575";

            if (openUI)
            {
                var url = $"{appUrl.TrimEnd('/')}/{routePrefix}";
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }

        }
    }
}
