namespace DotnetcoreCicdReferenceImplementation
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public static class program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
