using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using MinhaAgenciaApi.Models;

namespace MinhaAgenciaApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddDbContext<AgenciaDbContext>(options =>
                options.MySql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options) : base(options)
        {
        }

        // Adicione DbSet para cada entidade
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

    
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
    }

    public class Destino
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string DataIda { get; set; }
        public string DataVolta { get; set; }
        public short QtdQuartos { get; set; }

    
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }


    }
}
