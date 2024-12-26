namespace TraversingTheArray.Tests
{
    public class ExtensionDoubleArrayTests
    {
        [Fact]
        public void FindMinimum()
        {
            double[] mas = { 1, 2, 3, 4, 5 };
            double expected = 1;


            double actual = ExtensionDoubleArray.FindMinimum(mas);

            Assert.Equal(expected, actual);
        }




        [Theory]
        [InlineData(new double[] { 19, 34, 65, 1 }, 1)]
        [InlineData(new double[] { -19, 34, 65, 1 }, -19)]
        [InlineData(new double[] { 1, 1, 0, -1 }, -1)]
        [InlineData(new double[] { 0, 1, 2, 3, 4 }, 0)]
        [InlineData(new double[] { -19, -34, -65, -1 }, -65)]
        [InlineData(new double[] { 19, 34, 65, 1 }, 1)]

        public void MinimumTest(double[] mas, double expected)
        {
            double actual = ExtensionDoubleArray.FindMinimum(mas);
            Assert.Equal(expected, actual);
        }




        [Theory]
        [InlineData(new double[] { 19, 34, 65, 1 }, 65)]
        [InlineData(new double[] { -19, 34, -65, 1 }, 34)]
        [InlineData(new double[] { 1, 1, 0, -1 }, 1)]
        [InlineData(new double[] { 0, 1, 2, 3, 4 }, 4)]
        [InlineData(new double[] { 0, -1, -2, -3, -4 }, 0)]
        [InlineData(new double[] { -19, -34, -65, -1 }, -1)]

        public void MaximumTest(double[] mas, double expected)
        {
            double actual = ExtensionDoubleArray.FindMaximum(mas);
            Assert.Equal(expected, actual);
        }





        [Theory]
        [InlineData(new double[] { 19, 34, -65, 1 }, -15.5)]
        [InlineData(new double[] { -19, 34, 65, 1 }, 49.5)]
        [InlineData(new double[] { 1, 1, 0, -1 }, 0.5)]
        [InlineData(new double[] { 0, 1, 2, 3, 4 }, 2)]
        [InlineData(new double[] { -19, -34, -65, -1 }, -49.5)]
        [InlineData(new double[] { 19, 34, 5, 0, 0, 1 }, 2.5)]

        public void MedianTest(double[] mas, double expected)
        {
            double actual = ExtensionDoubleArray.FindMedian(mas);
            Assert.Equal(expected, actual);
        }





        [Theory]
        [InlineData(new double[] { 19, 34, -65, 1 }, -2.75)]
        [InlineData(new double[] { -19, 34, 65, 1 }, 20.25)]
        [InlineData(new double[] { 1, 1, 0, -1 }, 0.25)]
        [InlineData(new double[] { 0, 1, 2, 3, 4 }, 2)]
        [InlineData(new double[] { -19, -34, -65, -1 }, -29.75)]
        [InlineData(new double[] { 19, 34, 5, 0, 0, 1 }, 9.83333)]
        [InlineData(new double[] { double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue }, double.MaxValue)]
       
        public void AverageTest(double[] mas, double expected)
        {
            double actual = ExtensionDoubleArray.FindAverage(mas);
            Assert.Equal(expected, actual, 5);
        }





        [Theory]
        [InlineData(new double[] { 19, 34, 65, 1 }, 204.91462)]
        [InlineData(new double[] { 16, 16, 16, 16 }, 256.0)]
        [InlineData(new double[] { 16, 16, 3, 3 }, 48.0)]

        public void GeometricAverage_WorksCorrect(double[] mas, double expected)
        {
            double actual = ExtensionDoubleArray.FindGeometricAverage(mas);
            Assert.Equal(expected, actual, 5);
        }




        [Theory]
        [InlineData(new double[] { -19, 34, 65, 1 })]
        [InlineData(new double[] { 1, 1, 0, -1 })]
        [InlineData(new double[] { 0, 1, 2, 3, 4 })]
        [InlineData(new double[] { -19, -34, -65, -1 })]

        public void GeometricAverage_ThrowsOnBadInput(double[] mas)
        {
            Action action = () => mas.FindGeometricAverage();
            Assert.ThrowsAny<Exception>(action);
        }



        [Fact]
        public void FindMinimum_FoundEmptyArray()
        {
            double[] mas = { };

            Action action = () => mas.FindMinimum();
            Assert.ThrowsAny<Exception>(action);
        }




        public void FindMaximum_FoundEmptyArray()
        {
            double[] mas = { };

            Action action = () => mas.FindMaximum();
            Assert.ThrowsAny<Exception>(action);
        }




        public void FindAverage_FoundEmptyArray()
        {
            double[] mas = { };

            Action action = () => mas.FindAverage();
            Assert.ThrowsAny<Exception>(action);
        }



        public void FindMedian_FoundEmptyArray()
        { 
            double[] mas = { };

            Action action = () => mas.FindMedian();
            Assert.ThrowsAny<Exception>(action);
        }




        public void FindGeometricAverage_FoundEmptyArray()
        {
            double[] mas = { };

            Action action = () => mas.FindGeometricAverage();
            Assert.ThrowsAny<Exception>(action);
        }
    }
}