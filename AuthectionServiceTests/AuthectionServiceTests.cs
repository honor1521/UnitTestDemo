using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using SecurityFramework;
using SecurityFramework.Interfaces;


namespace SecurityFrameworkTest
{
    [TestClass]
    public class AuthectionServiceTest
    {
        [DataTestMethod]
        [DataRow("honor", "password", true)]
        [DataRow("alpha", "password", true)]
        [TestMethod]
        public void DoAuth_When_Auth_Service_Response_Is_0000_Should_Return_Success(string userName, string password, bool except)
        {
            //arrange
            var mockThirdService = Substitute.For<IThirdPartyAuthService>();
            var authService = new AuthectionService(mockThirdService);
            mockThirdService.DoAuthection(userName, password).Returns("0000");

            //act
            var actual = authService.DoAuth(userName, password);

            //assert
            Assert.AreEqual(except, actual);
        }
    }
}
