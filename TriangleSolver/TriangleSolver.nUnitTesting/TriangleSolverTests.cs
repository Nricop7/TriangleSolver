namespace TriangleSolver.nUnitTesting
{
    public class TriangleSolverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AnalyzeTriangle_AllSidesEqual_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 3;
            int secondSide = 3;
            int thirdSide = 3;
            string expectedResult = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            Triangle triangle = new Triangle();

            // Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
