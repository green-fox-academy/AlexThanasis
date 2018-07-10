using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RestApiWorkshop;
using System;
using Xunit;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestApiWorkshop.Controllers;

namespace RestApiWorkshopTest
{
    public class UnitTest1
    {
        private HttpClient Client { get; set; }
        private TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Test1(int input)
        {
            Assert.True(input < 10);
        }

        [Fact]
        public async Task ShouldGetDoubledReturnOK()
        {
            //arrange
            var response = await Client.GetAsync("/doubling?recieved=5");
            //act
            var statusCode = response.StatusCode;

            //assert

            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        [Fact]
        public async Task ShouldGetDoubledNumber()
        {
            //arrange
            var response = await Client.GetAsync("/doubling?recieved=5");
            //act
            //assert

            Assert.Equal(JsonConvert.SerializeObject(new { recieved = 5, result = 10 } ), response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("Pipi", "Megtorl�")]
        [InlineData("TDDNiki", "TDD")]
        public async Task ShouldGetGreeter(string name, string title)
        {
            //arrange
            var response = await Client.GetAsync("/greeter?name=" + name + "&title=" + title);
            //act
            var greet = JsonConvert.DeserializeObject<HomeController>(await response.Content.ReadAsStringAsync());

            //assert
            Assert.Equal(JsonConvert.SerializeObject(new { welcome_message = "Oh hi there " + name + " my dear " + title }), response.Content.ReadAsStringAsync().Result);
        }


    }
}
