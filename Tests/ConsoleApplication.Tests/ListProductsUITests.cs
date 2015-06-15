using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using StoreProject.UI.ConsoleApplication;
using StoreProject.Core;

namespace StoreProject.ConsoleApplication.Tests
{
    public class ListProductsUITests
    {
        [Fact]
        public void Run_OutputsTwoLines_WhenStoreHasTwoProducts()
        {
            var userInterface = new StringListUserInterface();
            var listProductsUI = new ListProductsUI(new Store());
            listProductsUI.Run(userInterface);

            userInterface.Lines.Should().HaveCount(2);
        }

        [Fact]
        public void Run_OutputsProductNames()
        {
            var userInterface = new StringListUserInterface();
            var listProductsUI = new ListProductsUI(new Store());
            listProductsUI.Run(userInterface);

            userInterface.Lines.Where(x => x.ToLower().Contains("knife"))
                .Any().Should().BeTrue();
            userInterface.Lines.Where(x => x.ToLower().Contains("nvidia"))
                .Any().Should().BeTrue();
        }
    }
}
