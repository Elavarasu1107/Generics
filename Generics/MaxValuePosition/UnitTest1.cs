using Generics;

namespace MaxValuePosition
{
    public class Tests
    {
        [Test]
        public void GetValue_CheckFirstPosition_PrintResult()
        {
            int firstValue = 100, secondValue = 75, thirdValue = 50;
            MaxFinder getmethod = new MaxFinder();
            var output = getmethod.ValueCheck<int>(firstValue, secondValue, thirdValue);
            Assert.AreEqual(firstValue, output);
        }

        [Test]
        public void GetValue_ChecksecondPosition_PrintResult()
        {
            int firstValue = 100, secondValue = 175, thirdValue = 50;
            MaxFinder getmethod = new MaxFinder();
            var output = getmethod.ValueCheck<int>(firstValue, secondValue, thirdValue);
            Assert.AreEqual(secondValue, output);
        }
        [Test]
        public void GetValue_CheckThirdPosition_PrintResult()
        {
            int firstValue = 100, secondValue = 175, thirdValue = 1150;
            MaxFinder getmethod = new MaxFinder();
            var output = getmethod.ValueCheck<int>(firstValue, secondValue, thirdValue);
            Assert.AreEqual(thirdValue, output);
        }
    }
}