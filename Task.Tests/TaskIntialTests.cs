using Microsoft.Owin.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tasks;

namespace Task.Tests
{
    public class TaskIntialTests
    {
        public async ta Should_be_Able_Get_Hello_World()
        {
            using (TestServer server=TestServer.Create<Startup>())
            {
                await server.HttpClient.GetAsync("/api/task");
            }
        }
    }
}
