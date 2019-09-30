using System.Globalization;
using System.Linq;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Book testTrueBook = new Book("tetle", "PoopFeast420Blazeit", 880,  "1234567891234");
        private Book testFalseBook = new Book("1", "noop", 5000, "12");

        [TestMethod]
        public void IsTitleTrue()
        {
            Assert.IsTrue(testTrueBook.Title.Length >= 2);
        }

        [TestMethod]
        public void IsTitleFalse()
        {
            Assert.IsFalse(testFalseBook.Title.Length >= 2);
        }

        [TestMethod]
        public void IsPagesTrue()
        {
            Assert.IsTrue(testTrueBook.Pages >= 9 && testTrueBook.Pages <= 1001);
        }

        [TestMethod]
        public void IsPagesFalse()
        {
            Assert.IsFalse(testFalseBook.Pages >= 9 && testFalseBook.Pages <=  1001);
        }

        [TestMethod]
        public void IsIsbnTrue()
        {
            Assert.IsTrue(testTrueBook.Isbn.Length == 13);
        }

        [TestMethod]
        public void IsIsbnFalse()
        {
            Assert.IsFalse(testFalseBook.Isbn.Length == 13);
        }
    }
}
