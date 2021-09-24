using BaseUnitTestProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringLanguageExtensions;

namespace BaseUnitTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void IsNullOrWhiteSpaceTest()
        {
            // arrange

            string value = "";
            Assert.IsTrue(value.IsNullOrWhiteSpace());

            value = "apples";
            Assert.IsFalse(value.IsNullOrWhiteSpace());
            // act


            // assert
        }
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void TestMethod2()
        {
            // TODO
        }
    }
}
