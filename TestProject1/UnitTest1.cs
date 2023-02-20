using VIN_LIB;

namespace TestProject1
{
    [TestClass]

    public class UnitTest1
    {
        //Пока легкие
        [TestMethod]
        public void CheckVINIsTrueCorrectVIN1()
        {
            Assert.IsTrue(Class1.CheckVIN("5gZCZ23d13s847842"));
        }

        [TestMethod]
        public void CheckVINIsTrueCorrectVIN2()
        {
            Assert.IsTrue(Class1.CheckVIN("2C4GM68475R667819"));
        }
        [TestMethod]
        public void CheckVINIsTrueCorrectVIN3()
        {
            Assert.IsTrue(Class1.CheckVIN("wauaC48H55K008231"));
        }

        [TestMethod]
        public void CheckVINIsTrueCorrectVIN4()
        {
            Assert.IsTrue(Class1.CheckVIN("JH4KA3263KC011910"));
        }


        [TestMethod]
        public void CheckVINIsFalseUncorrectVIN5()
        {
            Assert.IsFalse(Class1.CheckVIN("SP5512212232101"));
        }

        [TestMethod]
        public void CheckVINIsFalseUncorrectVIN6()
        {
            Assert.IsFalse(Class1.CheckVIN("IOQ301220121886u1"));
        }

        [TestMethod]
        public void CheckVINIsFalseUncorrectVIN7()
        {
            Assert.IsFalse(Class1.CheckVIN("O0Y11238425"));
        }

        [TestMethod]
        public void CheckVINIsFalseUncorrectVIN8()
        {
            Assert.IsFalse(Class1.CheckVIN("PKY400125411238DE12"));
        }


        [TestMethod]
        public void CheckVINCorrectType9()
        {
            Assert.IsInstanceOfType(Class1.CheckVIN("1B3ES66S63D169269"), typeof(bool));
        }

        [TestMethod]
        public void GetVINCountryCorrectType10()
        {
            Assert.IsInstanceOfType(Class1.GetVINCountry("1B3ES66S63D169269"), typeof(string));
        }

        //Сложные пошли
        [TestMethod]
        public void CheckVINSetEmptyspase1()
        {
            Assert.IsFalse(Class1.CheckVIN(" "));
        }

        [TestMethod]
        public void GetVINCountrySetEmptyspase2()
        {
            Assert.IsNotNull(Class1.GetVINCountry(" "));
        }

        [TestMethod]
        public void GetVINCountry_NotCorrectlyVin3()
        {
            Assert.IsNotNull(Class1.GetVINCountry("123123123123123123123"));
        }

        [TestMethod]
        public void CheckVINSetEmptySpase4()
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.CheckVIN(null)));
        }

        [TestMethod]
        public void GetVINCountrySetEmptySpase5()
        {
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Class1.GetVINCountry(null)));
        }



    }
}
