﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();

            var expected = new List<Vendor>();
            expected.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
            expected.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Corp", Email = "xyz@xyz.com" });
            
            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual.ToList());
        }

      
    }
}