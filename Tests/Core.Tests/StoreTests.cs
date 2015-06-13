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
    public class StoreTests
    {
        [Fact]
        public void FindProduct_ReturnsProduct_IfPartialSKUisInput()
        {
            var store = new Store();
            var find = store.FindProduct("NV");
            find.Sku.Should().Be("NV970");
        }

        [Fact]
        public void FindProduct_ReturnsProduct_ifSKUisLowercase()
        {
            var store = new Store();
            var find = store.FindProduct("nv");
            find.Sku.Should().Be("NV970");

        }
    }
}
