namespace TriangleSolver.nUnitTesting
{
    public class TriangleSolverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // EQUILATERAL TEST
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

        // SCALENE TESTS

        [Test]
        public void AnalyzeTriangle_UserInput_ValidScalene_1()
        {
            //Assign
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;
            string expectedResult = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_UserInput_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_UserInput_ValidScalene_2()
        {
            //Assign
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 4;
            string expectedResult = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_UserInput_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_UserInput_ValidScalene_3()
        {
            //Assign
            int firstSide = 5;
            int secondSide = 6;
            int thirdSide = 4;
            string expectedResult = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_UserInput_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_UserInput_ValidScalene_4()
        {
            //Assign
            int firstSide = 4;
            int secondSide = 6;
            int thirdSide = 5;
            string expectedResult = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_UserInput_ValidScalene_4 failed");
        }

        [Test]
        public void AnalyzeTriangle_UserInput_ValidScalene_5()
        {
            //Assign
            int firstSide = 4;
            int secondSide = 6;
            int thirdSide = 7;
            string expectedResult = "Based on all three sides being different, the type of triangle is a SCALENE";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_UserInput_ValidScalene_4 failed");
        }







    }
}
