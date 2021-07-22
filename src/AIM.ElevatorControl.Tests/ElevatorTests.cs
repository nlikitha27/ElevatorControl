using System;
using Xunit;

namespace AIM.ElevatorControl.Tests
{
    public class ElevatorTests
    {
        [Fact]
        public void GetAllWhenEmpty()
        {
            var sut = new Elevator();

            var result = sut.All();

            Assert.Equal(new int[0], result);
        }

        [Fact]
        public void GetAllRequesting()
        {
            var sut = new Elevator();
            sut.FloorRequest(0, null);

            var result = sut.All();

            Assert.Equal(new int[1] { 0 }, result);
        }

        [Fact]
        public void FloorIsWrong()
        {
            var sut = new Elevator();

            void act() => sut.FloorRequest(10000, null);

            Assert.Throws<IndexOutOfRangeException>(act);
        }

        [Fact]
        public void NullNextIfEmpty()
        {
            var sut = new Elevator();

            var result = sut.Next();

            Assert.Null(result);
        }

        [Fact]
        public void NextZero()
        {
            var sut = new Elevator();
            sut.FloorRequest(0);

            var result = sut.Next();

            Assert.Equal(0, result);
        }
    }
}
