using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MemoryPicture;
namespace UnitTestProjectMemoryPic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //1
            rmot f1 = new rmot("user1", 1);
            Assert.IsFalse(f1.userName() == true);

        }


        public void TestMethod2()
        {
            Profile f1 = new Profile();
            Assert.IsTrue(f1.ShowpicGold(90) == false);

        }



        public void TestMethod3()
        {
            Profile f1 = new Profile("user1");
            Assert.IsTrue(f1.IfUser("user1") == true);
        }




        public void TestMethod4()
        {
            EndGame f1 = new EndGame();
            Assert.IsFalse(f1.IfUser("user1") == true);

        }



        public void TestMethod5()
        {
            EndGame f1 = new EndGame();
            Assert.IsFalse(f1.IfUser("user1") == true);

        }
    }
}
