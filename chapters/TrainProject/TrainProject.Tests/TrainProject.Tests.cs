using NUnit.Framework;
using TrainProject.Models;
using TrainProject.Services;

namespace TrainProject.Tests
{
    [TestFixture]
    public class TrainServiceTests
    {
        [Test]
        public void TestDisplayTrainInfo()
        {
            // Arrange
            Train train = new Train
            {
                Name = "Express 123",
                NumberOfPassengers = 150
            };

            TrainService trainService = new TrainService();

            // Act
            // Call the method to be tested (if any)

            // Assert
            // Make assertions to verify the expected behavior
            // Example:
            Assert.AreEqual("Express 123", train.Name);
            Assert.AreEqual(150, train.NumberOfPassengers);
        }

        // Add more test methods as needed to cover various scenarios
    }
}
