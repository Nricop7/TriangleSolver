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


        //ISOSCELES TESTS

        [Test]
        public void AnalyzeTriangle_TwoSidesEqual_ValidIsoceles_1()
        {
            //Assign
            int firstSide = 3;
            int secondSide = 3;
            int thirdSide = 5;
            string expectedResult = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_TwoSidesEqual_ValidIsoceles failed");

        }

        [Test]
        public void AnalyzeTriangle_TwoSidesEqual_ValidIsoceles_2()
        {
            //Assign
            int firstSide = 2;
            int secondSide = 4;
            int thirdSide = 4;
            string expectedResult = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_TwoSidesEqual_ValidIsoceles failed");

        }

        [Test]
        public void AnalyzeTriangle_TwoSidesEqual_ValidIsoceles_3()
        {
            //Assign
            int firstSide = 5;
            int secondSide = 3;
            int thirdSide = 5;
            string expectedResult = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            Triangle triangle = new Triangle();

            //Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_TwoSidesEqual_ValidIsoceles failed");

        }


        // SCALENE TESTS

        [Test]
        public void AnalyzeTriangle_AllSidesDifferent_ValidScalene_1()
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
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_AllSidesDifferent_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_AllSidesDifferent_ValidScalene_2()
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
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_AllSidesDifferent_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_AllSidesDifferent_ValidScalene_3()
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
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_AllSidesDifferent_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_AllSidesDifferent_ValidScalene_4()
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
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_AllSidesDifferent_ValidScalene failed");
        }

        [Test]
        public void AnalyzeTriangle_AllSidesDifferent_ValidScalene_5()
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
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_AllSidesDifferent_ValidScalene failed");
        }


        // ZERO SIDES TEST

        [Test]
        public void AnalyzeTriangle_InputContainsZero_ReturnsInvalid_1()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 3;
            int thirdSide = 4;
            string expectedResult = "At least one side of your triangle has a zero length and is thus invalid";
            Triangle triangle = new Triangle();

            // Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_InputContainsZero_ReturnsInvalid failed");
        }

        [Test]
        public void AnalyzeTriangle_InputContainsZero_ReturnsInvalid_2()
        {
            // Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 4;
            string expectedResult = "At least one side of your triangle has a zero length and is thus invalid";
            Triangle triangle = new Triangle();

            // Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_InputContainsZero_ReturnsInvalid failed");
        }

        [Test]
        public void AnalyzeTriangle_InputContainsZero_ReturnsInvalid_3()
        {
            // Arrange
            int firstSide = 1;
            int secondSide = 2;
            int thirdSide = 0;
            string expectedResult = "At least one side of your triangle has a zero length and is thus invalid";
            Triangle triangle = new Triangle();

            // Act
            string actualResult = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expectedResult, actualResult, "AnalyzeTriangle_InputContainsZero_ReturnsInvalid failed");
        }


        //INVALID TESTS

        [Test]
        public void AnalyzeTriangle_InvalidSides_ReturnsInvalidTriangle_1()
        {
            // Arrange
            Triangle triangle = new Triangle();
            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 7;

            // Act
            string result = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("Based on the values entered, the triangle is INVALID", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidSides_ReturnsInvalidTriangle_2()
        {
            // Arrange
            Triangle triangle = new Triangle();
            int firstSide = -2;
            int secondSide = -4;
            int thirdSide = -3;

            // Act
            string result = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("Based on the values entered, the triangle is INVALID", result);
        }

        [Test]
        public void AnalyzeTriangle_InvalidSides_ReturnsInvalidTriangle_3()
        {
            // Arrange
            Triangle triangle = new Triangle();
            int firstSide = 3;
            int secondSide = 3;
            int thirdSide = 8;

            // Act
            string result = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("Based on the values entered, the triangle is INVALID", result);
        }


    }
}
