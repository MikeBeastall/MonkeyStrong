using System.Web.Http.Results;
using FluentAssertions;
using MonkeyStrong.Api.Controllers.User;
using MonkeyStrong.Common.Responses;
using NUnit.Framework;

namespace MonkeyStrong.Api.Tests.Controllers.User
{
    [TestFixture]
    public class ClimbControllersTests
    {
        [Test]
        public void CanGet()
        {
            // Arrange
            const string name = "witnessthefitness";

            var controller = new ClimbController();

            // Act
            var result = (OkNegotiatedContentResult<ClimbResponse>) controller.Get(name);

            // Assert
            result.Should().NotBeNull();
        }
    }
}