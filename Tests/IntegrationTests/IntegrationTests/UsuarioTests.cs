using Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTests
{
    public class UsuarioTests
    {
        //A fixture mantém estado,com isso para cada teste será reutilizada a instancia do servidor
        private readonly IntegrationTestsFixture<StartupApiTest> _testsFixture;

        public UsuarioTests(IntegrationTestsFixture<StartupApiTest> testsFixture)
        {
            _testsFixture = testsFixture;
        }
    }
}
