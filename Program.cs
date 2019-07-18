namespace DotnetcoreCicdReferenceImplementation
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    /// <summary>
    /// Entry class to program
    ///</summary>
    public static class program
    {
        /// <summary>
        /// Entry to program
        ///</summary>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Create the webapi
        ///</summary>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
