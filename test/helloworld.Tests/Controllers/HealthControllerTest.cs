using HelloWorld.Controllers;
using Xunit;

namespace TestNamespace.Controllers
{
    public class TestHealthController
  {
    [Fact]
    public void ThisWillPass()
    {
      var controller = new HealthController();
      Assert.True(true);
    }
  }
}
