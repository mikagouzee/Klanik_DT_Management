using Klanik_Internal.Repository;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System;

namespace Tests {
    public class Tests {
        protected readonly TestServer server;
        protected readonly IServiceProvider provider;
        [SetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilderFactory().use)
        }

        [Test]
        public void Test1()
        {
            var APIRepo = new CountryRepository(provider);
            var Countries = APIRepo.GetAll();
            Assert.IsNotNull(Countries);

        }
    }
}