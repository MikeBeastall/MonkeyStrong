using FluentAssertions;
using MonkeyStrong.Api.Extensions;
using MonkeyStrong.Api.Models;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace MonkeyStrong.Api.Tests.Extensions
{
    [TestFixture]
    public class ClimbExtensionsTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void CanGetResponse()
        {
            // Arrange
            var climb = _fixture.Create<Climb>();

            // Act
            var result = climb.ToResponse();

            // Assert
            result.LatLong.ShouldBeEquivalentTo(climb.LatLong);
            result.Name.ShouldBeEquivalentTo(climb.Name);
            result.Rating.ShouldBeEquivalentTo(climb.Rating);
            result.Styles.ShouldBeEquivalentTo(climb.Styles);
        }
    }
}