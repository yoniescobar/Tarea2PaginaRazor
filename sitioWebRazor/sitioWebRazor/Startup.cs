namespace sitioWebRazor
{
    public class Startup
    {
        //servicio para razor
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }
       //metodo para configurar la app y probar la aplicacion en Environment
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHsts();
            }
            app.UseRouting(); //usar paths
            app.UseDefaultFiles(); //usar index.cshtml
            app.UseStaticFiles(); //carperta wwwroot
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

        }
    }
}
