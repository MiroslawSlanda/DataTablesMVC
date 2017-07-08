using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataTablesMvc.Infrastructure;

namespace DataTablesMvc.Tests
{
    [TestClass]
    public class ServerSide_Tests
    {
        DataTableRequest _request;

        [TestInitialize]
        public void Init()
        {
            _request = new DataTableRequest()
            {
                Start = 0,
                Length = 10,
                Columns = new List<ColumnsRequest>()
                {
                    new ColumnsRequest()
                    {
                        Name = "FirstName",
                        Orderable = true
                    },
                    new ColumnsRequest()
                    {
                        Name = "LastName",
                        Orderable = true
                    }
                },
                Orders = new List<OrderRequest>()
                {
                    new OrderRequest()
                    {
                        Column = 0
                    }
                }
            };
        }

        [TestMethod]
        public void TestOrderBy()
        {
            var query = (new[]
            {
                new Person("C", "C"),
                new Person("B", "B"),
            }).AsQueryable();

            var items = query.ToList();

            Assert.AreEqual(items[0].FirstName, "B");
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
