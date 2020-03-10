using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTests.Config
{
    /// <summary>
    /// A classe loja Factory está herdando da classe WebApplicationFactory, esperando que seja passado classe TStartup
    /// where TStartup seja uma classe, isto é classe genérica.
    /// </summary>
    /// <typeparam name="TStartup"></typeparam>
    public class LojaAppFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            //Temos que usar uma startup específica, qual uma genérica
            builder.UseStartup<TStartup>(); 
            //O contexto de teste irá buscar as variáveis de ambiente configurado no startup
            builder.UseEnvironment("Testing");
        }
    }
}
