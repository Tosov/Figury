using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguryLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(2, 3, 4)]
        [DataRow(1, 1, 1)]
        public void ConstructorPoprawneDaneTrojkatUtrorzony(double a, double b, double c)
        {
            //AAA
            ///Arange

            

            ///Act
            Trojkat T = new Trojkat(a, b, c);

            ///Asert
            Assert.AreEqual(a, T.A);
            Assert.AreEqual(b, T.B);
            Assert.AreEqual(c, T.C);


        }

        [TestMethod]
        public void ConstructorDeafultPoprawnie()
        {
            //Arrange
            
            //Act
            Trojkat t = new Trojkat();

            //Assert
            Assert.AreEqual(1, t.A);
            Assert.AreEqual(1, t.B);
            Assert.AreEqual(1, t.C);


        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-1,1,1)]
        [DataRow(1,-1,1)]
        [DataRow(1,1,-1)]
        public void ConstructorUjemnyParametr_ArgumentOutOfRangeException(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException))]
        [DataRow(1, 1, 100)]
        [DataRow(100, 1, 1)]
        [DataRow(1, 100, 1)]
        public void ConstructorNieSpelnionyWarunekTrojkata_ArgumentException(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1, 3)]
        [DataRow(3, 4, 5, 12)]
        public void PropertyObwod_Poprawnie(double a, double b, double c, double wynik)
        {
            //Act
            var t = new Trojkat(a, b, c);

            //Assert
            Assert.AreEqual(wynik, t.Obwod);
        }

        



    }
}
