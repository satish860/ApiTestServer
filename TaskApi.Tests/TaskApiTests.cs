using Microsoft.Owin.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tasks;
using FluentAssertions;

namespace TaskApi.Tests
{
    public class TaskApiTests
    {
        public async Task Should_be_Able_Get_Hello_World()
        {
            using (TestServer server = TestServer.Create<Startup>())
            {
                HttpResponseMessage response = await server.HttpClient.GetAsync("/api/task");
                response.IsSuccessStatusCode.Should().BeTrue();
              
            }
        }
    }
}
