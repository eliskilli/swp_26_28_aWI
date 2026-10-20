using System.IO;
using FirstOOP;
using NUnit.Framework;

namespace MyFirstTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KuhConstructor_IsCalled_SetsValuesCorrect()
        {
            Kuh myKuh = new Kuh("Paula", "Schwarz");

            Assert.That(myKuh.Name, Is.EqualTo("Paula"));
        }

        [Test]
        public void KuhConstructor_EmptyName_ThrowsInvalidDataException()
        {
            Assert.Throws<InvalidDataException>(
                () => new Kuh("", "Schwarz"));
        }
    }
}