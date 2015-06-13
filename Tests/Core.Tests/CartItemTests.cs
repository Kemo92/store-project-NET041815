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
    public class CartItemTests
    {
        [Fact]
        public void Price_ReturnsProductPriceTimesQuantity()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cartItem = new CartItem(product, 3);

            cartItem.Price.Should().Be(10.50m);
        }

        [Fact]
        public void ChangeQuantityBy_AddsSpecifiedQuantityToExistingQuantity()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cartItem = new CartItem(product, 3);
            cartItem.ChangeQuantityBy(2);
            cartItem.Quantity.Should().Be(5);
        }

        [Fact]
        public void ChangeQuantityBy_DosntReturnNegitiveQuantity()
        {
            var product = new Product("Foo", "Bar", 3.50m);
            var cartItem = new CartItem(product, 3);
            cartItem.ChangeQuantityBy(-4);
            cartItem.Quantity.Should().Be(0);
        }
    }
}
