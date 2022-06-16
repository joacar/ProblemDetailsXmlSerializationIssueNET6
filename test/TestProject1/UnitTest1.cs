using Microsoft.AspNetCore.Mvc.Testing;
using ProblemDetailsXMLSerialization;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            // Arrange
            var application = new WebApplicationFactory<Startup>();
            var client = application.CreateClient();

            // Act
            const string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<note>
  <to>Tove</to>
  <from>Jani</from>
  <heading>Reminder</heading>
  <body>Don't forget me this weekend!</body>
</note>";
            var content = new StringContent(xml, Encoding.UTF8, MediaTypeNames.Application.Xml);
            var response = await client.PostAsync("xml", content);

            // Assert
            Assert.Equal(MediaTypeNames.Application.Xml, response.Content.Headers.ContentType.MediaType);
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}