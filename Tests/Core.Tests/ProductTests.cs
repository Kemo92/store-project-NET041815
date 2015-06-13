using StoreProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace StoreProjects.Core.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Constructor_SetsProperties_WhenPropertiesAreValid()
        {
            var product = new Product("Foo", "Bar", 3.95m);
            Assert.Equal("Foo", product.Name); // Using xunit assertions
            product.Sku.Should().Be("Bar");    // Using fluent assertions
            product.Price.Should().Be(3.95m);
        }

        [Fact]
        public void ToString_ShowsSkuNameAndPrice()
        {
            var product = new Product("Foo", "Bar", 3.95m);
            product.ToString().Should().Be("(Bar) Foo: 3.95");
        }
    }
}
