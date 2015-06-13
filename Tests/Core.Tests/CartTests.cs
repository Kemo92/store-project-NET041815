using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using StoreProject.Core;

namespace StoreProjects.Core.Tests
{
    public class CartTests
    {
        [Fact]
        public void Add_AddsToCart_WithProductAndQuantity()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cart = new Cart();
            cart.Add(product, 3);
            cart.Products.Should().Contain(product);
        }

        [Fact]
        public void Quanity_CannotAddANegativeQuanity()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cart = new Cart();

            Action act = () => cart.Add(product, -2);
            act.ShouldThrow<Exception>();
        }


        [Fact]
        public void Price_ReturnsSumOfProductPrices()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var product2 = new Product("Foo2", "Bar2", 2.50m);
            var cart = new Cart();
            cart.Add(product, 1);
            cart.Add(product2, 2);
            cart.Price.Should().Be(8.50m);
        }

        [Fact]
        public void Products_ReturnsOneProduct_WhenProductIsAddedTwice()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cart = new Cart();
            cart.Add(product, 1);
            cart.Add(product, 2);
            cart.Products.Should().HaveCount(1);
        }
    }
}
