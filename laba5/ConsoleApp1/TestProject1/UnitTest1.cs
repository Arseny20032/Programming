using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using task;

namespace task
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            cliient cl = cliient.poor;
            client_Contribution a = client_Contribution.GetNewClient(cl, "Artem Bobrov", 200, 2);

            cliient cl_1 = cliient.rich;
            client_Contribution b = client_Contribution.GetNewClient(cl_1, "Evgeniu Kyznetsov", 500, 6);

            Assert.Equal("Artem Bobrov", a.GetName());
            Assert.Equal(200, a.GetAmount());

            a.IncreaseAmount(100);
            Assert.Equal(300, a.GetAmount());

            a.DecreaseAmount(200);
            Assert.Equal(100, a.GetAmount());

            Assert.Equal(2, a.GetBet());

            Assert.Equal(30, b.Payment());

            Assert.Equal("Evgeniu Kyznetsov", b.GetName());
            Assert.Equal(500, b.GetAmount());

            b.IncreaseAmount(100);
            Assert.Equal(600, b.GetAmount());

            b.DecreaseAmount(200);
            Assert.Equal(400, b.GetAmount());

            Assert.Equal(24, b.Payment());
        }
    }
}