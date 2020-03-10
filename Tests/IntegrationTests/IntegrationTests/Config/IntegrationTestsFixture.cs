using Api;
using IntegrationTests.Config;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using Xunit;

namespace IntegrationTests
{

    //Para cada coleção irá iniciar um startup diferentes
    [CollectionDefinition(nameof(IntegrationWebTestsFixtureCollection))]
    public class IntegrationWebTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<StartupWebTest>> { }

    [CollectionDefinition(nameof(IntegrationApiTestsFixtureCollection))]
    public class IntegrationApiTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<StartupApiTest>> { }

    /// <summary>
    /// Classe utilizada para poder compartilhar código com todos os testes
    /// </summary>
    public class IntegrationTestsFixture<TStartup> : IDisposable where TStartup : class
    {

        public readonly LojaAppFactory<TStartup> Factory;
        public HttpClient Client;

        public IntegrationTestsFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions
            {
                
            };
            Factory = new LojaAppFactory<TStartup>();
            //Irá emular uma aplicação na memória
            Client = Factory.CreateClient(clientOptions);
        }
        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }      
    }   
}
