using Generics;

namespace MaxValuePosition
{
    public class IntegerTests
    {
        [Test]
        public void GetValue_CheckFirstInt_PrintResult()
        {
            int firstValue = 100, secondValue = 75, thirdValue = 50;
            MaxFinder<int> getmethod = new MaxFinder<int>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(firstValue, output);
        }
        [Test]
        public void GetValue_CheckSecondInt_PrintResult()
        {
            int firstValue = 100, secondValue = 175, thirdValue = 50;
            MaxFinder<int> getmethod = new MaxFinder<int>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(secondValue, output);
        }
        [Test]
        public void GetValue_CheckThirdInt_PrintResult()
        {
            int firstValue = 100, secondValue = 175, thirdValue = 1150;
            MaxFinder<int> getmethod = new MaxFinder<int>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(thirdValue, output);
        }
    }
    public class FloatTests
    {
        [Test]
        public void GetValue_CheckFirstFloat_PrintResult()
        {
            float firstValue = 100.2564F, secondValue = 75.6587F, thirdValue = 50.6214F;
            MaxFinder<float> getmethod = new MaxFinder<float>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(firstValue, output);
        }
        [Test]
        public void GetValue_ChecksecondFloat_PrintResult()
        {
            float firstValue = 50.5455F, secondValue = 100.4546F, thirdValue = 75.5154F;
            MaxFinder<float> getmethod = new MaxFinder<float>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(secondValue, output);
        }
        [Test]
        public void GetValue_CheckThirdFloat_PrintResult()
        {
            float firstValue = 100.5456F, secondValue = 175.5456F, thirdValue = 1150.4165F;
            MaxFinder<float> getmethod = new MaxFinder<float>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(thirdValue, output);
        }
    }
    public class StringTests
    {
        [Test]
        public void GetValue_CheckFirstString_PrintResult()
        {
            string firstValue = "Peach", secondValue = "Apple", thirdValue = "Banana";
            MaxFinder<string> getmethod = new MaxFinder<string>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(firstValue, output);
        }
        [Test]
        public void GetValue_ChecksecondString_PrintResult()
        {
            string firstValue = "Apple", secondValue = "Peach", thirdValue = "Banana";
            MaxFinder<string> getmethod = new MaxFinder<string>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(secondValue, output);
        }
        [Test]
        public void GetValue_CheckThirdString_PrintResult()
        {
            string firstValue = "Banana", secondValue = "Apple", thirdValue = "Peach";
            MaxFinder<string> getmethod = new MaxFinder<string>(firstValue, secondValue, thirdValue);
            var output = getmethod.ValueCheck();
            Assert.AreEqual(thirdValue, output);
        }
    }
}