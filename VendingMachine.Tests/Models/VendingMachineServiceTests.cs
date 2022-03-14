using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Models;

namespace VendingMachine.Tests.Models
{
    public class VendingMachineServiceTests
    {
        [Fact]

        public void CreatandSaveSnackTest()
        {
            //Arrang

            string Name = "Choclate";
            int Price = 15;
            string Information = "PLEASE TAKE OFF PAKET OF CHOCLATE AND THEN USE IT";
            int ProductId = 13;
            string Family = "SWETIE";

            Snack snack = new Snack(Name, Price, Information, ProductId, Family);

            //Act
            VendingMachinService service = new VendingMachinService();

            Product productResult = service.CreateAndSave(snack);

            //Assert

            Assert.NotNull(productResult);
            Assert.Contains(productResult, service.ShowAll());
            Assert.NotEqual(0, productResult.ProductId);
            Assert.Equal(Name, productResult.Name);
            Assert.Equal(Price, productResult.Price);
            Assert.Equal(Information, productResult.Information);
            Assert.Equal(Family , (productResult as Snack).Family);

        }

        [Fact]

        public void  DetailsTest()
        {//arrange
            
            string Name = "Chips";
            int Price = 20;
            string Information = "please take the chips";
            int productId = 11;
            string Family = "junkfood";

            Snack snack = new Snack(Name, Price, Information, productId,Family);

            //act
            VendingMachinService service = new VendingMachinService();
            foreach (Product  product in service .storage )
            {
                string productResult = service.Details( product as Snack);

                //assert
                Assert.Equal(Name, productResult);
                Assert.Equal(Convert .ToString (Price) , productResult);
                Assert.Equal(Information, productResult);
                Assert.Equal(Convert.ToString (productId), productResult);
                Assert.Equal(Family, productResult);

            }
            

        }
    }
}
