using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module14.ViewModels;

namespace Module14.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {

            //Arrange
            var vm = new MathViewModel();
            vm.ValA = 6;
            vm.ValB = 7;
            //Act

            vm.AddCommand.Execute(null);

            //Assert

            Assert.IsTrue(vm.Result == 13, "vm.Result !=13");
        }
    }
}
