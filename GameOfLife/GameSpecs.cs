using FluentAssertions;
using Xunit;

namespace GameOfLife
{
    public class GameSpecs
    {
        [Fact]
        public void Block()
        {
            ObjectMother.Block.Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Block);
        }

        [Fact]
        public void Beehive()
        {
            ObjectMother.Beehive.Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Beehive);
        }

        [Fact]
        public void Loaf()
        {
            ObjectMother.Loaf.Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Loaf);
        }

        [Fact]
        public void Boat()
        {
            ObjectMother.Boat.Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Boat);
        }

        [Fact]
        public void Tub()
        {
            ObjectMother.Tub.Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Tub);
        }

        [Fact]
        public void Blinker()
        {
            ObjectMother.Blinker[0].Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Blinker[1]);
        }

        [Fact]
        public void Toad()
        {
            ObjectMother.Toad[0].Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Toad[1]);
        }

        [Fact]
        public void Beacon()
        {
            ObjectMother.Beacon[0].Next()
                .Should()
                .BeEquivalentTo(ObjectMother.Beacon[1]);
        }
    }
}
