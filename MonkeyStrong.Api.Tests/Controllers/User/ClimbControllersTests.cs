using System.Threading.Tasks;
using System.Web.Http.Results;
using FluentAssertions;
using MonkeyStrong.Api.Controllers.User;
using MonkeyStrong.Api.DataStore.Interfaces;
using MonkeyStrong.Api.DataStore.Repositories.Parameters;
using MonkeyStrong.Api.Extensions;
using MonkeyStrong.Api.Models;
using MonkeyStrong.Common.Responses;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace MonkeyStrong.Api.Tests.Controllers.User
{
    [TestFixture]
    public class ClimbControllersTests
    {
        [SetUp]
        public void SetUp()
        {
            _climbRepositoryMock = _repository.Create<IClimbRepository>();
        }

        private readonly MockRepository _repository = new MockRepository(MockBehavior.Strict);
        private readonly Fixture _fixture = new Fixture();
        private Mock<IClimbRepository> _climbRepositoryMock;

        [Test]
        public async Task CanGet()
        {
            // Arrange
            const string name = "witnessthefitness";

            var climb = _fixture.Create<Climb>();
            climb.Name = name;

            _climbRepositoryMock.Setup(c => c.GetAsync(Match.Create<GetClimbsParameters>(p => p.Name == name)))
                .Returns(Task.FromResult(climb));

            var controller = new ClimbController(_climbRepositoryMock.Object);

            // Act
            var result = (OkNegotiatedContentResult<ClimbResponse>) controller.Get(name).Result;

            // Assert
            result.Content.ShouldBeEquivalentTo(climb.ToResponse());
        }
    }
}