using Microsoft.VisualStudio.TestTools.UnitTesting;
public class Joiner
{

}

namespace Interview
{
    [TestClass]

    public class JoinerTests

    {

        [TestMethod]

        public void ItShouldReturnAStringRepresentationOfAnArray()

        {

            var sut = new Joiner();

            var result = sut.Join(new int[] { 1, 7, 59, 42, 13 });

            Assert.AreEqual("1, 7, 59, 42, 13", result);

        }

        //[TestMethod]
        //public void ItShouldAllowSeparatorSpecification()

        //{

        //    var sut = new Joiner();

        //    var result = sut.Join(new int[] { 1, 7, 59, 42, 13 }, "|");

        //    Assert.AreEqual("1|7|59|42|13", result);

        //}

        //[TestMethod]

        //public void ItShouldHandleDecimalValues()

        //{

        //    var sut = new Joiner();

        //    var result = sut.Join(new decimal[] { 1.2m, 7.5m, 59.3m, 42.2m, 13.35m });

        //    Assert.AreEqual("1.2, 7.5, 59.3, 42.2, 13.35", result);

        //}

        //[TestMethod]

        //public void ItShouldHandleIQueryable()

        //{

        //    var sut = new Joiner();

        //    var result = sut.Join(new int[] { 1, 7, 59, 42, 13 }.AsQueryable());

        //    Assert.AreEqual("1, 7, 59, 42, 13", result);

        //}

        //[TestMethod]

        //public void ItShouldUseCustomFormatter()

        //{

        //    var sut = new Joiner();

        //    var people = new Person[] {

        //        new Person()

        //        {

        //            Name = "Bob",

        //            Age = 42,

        //        },

        //        new Person()

        //        {

        //            Name = "Tina",

        //            Age = 13,

        //        },

        //    };

        //    var result = sut.Join(people, formatter: FormatPerson);

        //    Assert.AreEqual("Bob - 42, Tina - 13", result);

        //}
    }
}
