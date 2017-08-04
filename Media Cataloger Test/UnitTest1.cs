using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Media_Cataloger_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProject()
        {
            var testShelf = new Media_Cataloger.Virtual_Shelf();
            testShelf.AddNewMedia("Video");


            

        }
    }
}
