using System;
using Xunit;
using LibraryWebServer.Controllers;
using LibraryWebServer.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace UnitTests
{

    public class UnitTest1
    {
        private static ServiceProvider NewServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
              .AddEntityFrameworkInMemoryDatabase()
              .BuildServiceProvider();
            return serviceProvider;
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
