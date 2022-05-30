using Generics;

namespace MaxValuePosition
{
    public class Tests
    {
        [Test]
        public void GetValue_CheckInteger_PrintResult()
        {
            int firstValue = 100, secondValue = 75, thirdValue = 50, fourthValue = 250, fifthValue = 200;
            MaxFinder<int> getmethod = new MaxFinder<int>(firstValue, secondValue, thirdValue, fourthValue, fifthValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(fourthValue, output);
        }
        [Test]
        public void GetValue_CheckFloat_PrintResult()
        {
            float firstValue = 100.2564F, secondValue = 750.6587F, thirdValue = 50.6214F, fourthValue = 250.4452F, fifthValue = 200.6465F;
            MaxFinder<float> getmethod = new MaxFinder<float>(firstValue, secondValue, thirdValue, fourthValue, fifthValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(secondValue, output);
        }
        [Test]
        public void GetValue_CheckString_PrintResult()
        {
            string firstValue = "Peach", secondValue = "Apple", thirdValue = "Banana", fourthValue = "Mango", fifthValue = "Grapes";
            MaxFinder<string> getmethod = new MaxFinder<string>(firstValue, secondValue, thirdValue, fourthValue, fifthValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(firstValue, output);
        }
    }
}