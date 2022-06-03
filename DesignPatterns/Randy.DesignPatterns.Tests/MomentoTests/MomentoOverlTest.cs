namespace Randy.DesignPatterns.Tests.MomentoTests
{
    using FluentAssertions;

    using Randy.DesignPatterns.Momento;

    public class MomentoOverlTest
    {
        [Fact]
        public void OveralTest_Momento_Pattern()
        {
            // Arrange
            var originator = new Originator("Hi Momento", 1);
            var careTaker = new CareTaker<Originator>(originator);

            // Act
            careTaker.TakeSnapshot();
            
            originator.SetScore(5);
            careTaker.TakeSnapshot();

            originator.SetScore(10);
            careTaker.TakeSnapshot();

            originator.SetScore(15);
            careTaker.TakeSnapshot();

            originator.SetScore(20);
            careTaker.TakeSnapshot();

            originator.SetScore(21);

            // Assert
            careTaker.GetAllSnapshots().Should()
                .HaveCount(5);
            originator.State1.Should()
                .NotBeNullOrEmpty()
                .And
                .Be("Hi Momento");
            originator.GetState2().Should()
                .Be(21);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(4);
            originator.GetState2().Should()
                .Be(20);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(3);
            originator.GetState2().Should()
                .Be(15);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(2);
            originator.GetState2().Should()
                .Be(10);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(1);
            originator.GetState2().Should()
                .Be(5);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(0);
            originator.GetState2().Should()
                .Be(1);

            careTaker.RestoreSnapshot();
            careTaker.GetAllSnapshots().Should()
                .HaveCount(0);
            originator.GetState2().Should()
                .Be(1);
        }
    }
}