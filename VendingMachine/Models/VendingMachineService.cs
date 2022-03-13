using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Models;

namespace VendingMachine.Models
{
    public class VendingMachinService : IVending
    {
        public List<Product> storage = new List<Product>();

        public int[] moneyArray = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public List<int> moneyPool = new List<int>();


        public int payment;
        Dictionary<int, int> transactionDic = new Dictionary<int, int>();


        public Product CreateAndSave(Product data)
        {
            Product product = null;
            if (data is Drink)
            {
                product = new Drink(
                    data.Name,
                    data.Price,
                    data.Information,
                    ProductSequencer.NextProductId(),

                    (data as Drink).Brand
                    );

            }
            else if (data is Snack)
            {
                product = new Snack(
                    data.Name,
                    data.Price,
                    data.Information,
                    ProductSequencer.NextProductId(),
                    (data as Snack).Family
                    );
            }

            else if (data is Food)
            {
                product = new Food(
                    data.Name,
                    data.Price,
                    data.Information,
                    ProductSequencer.NextProductId(),
                    (data as Food).Type
                    );
            }
            storage.Add(product);

            return product;
        }
        public List<Product> ShowAll()
        {
            return storage;
        }

        public string Details(Product selctedproduct)
        {
            foreach (Product product in storage)
            {
                if (selctedproduct == product)
                {
                    if (product is Snack)
                    {
                        return $"Products Id: {product.ProductId } - Products Name:{product.Name  } -" +

                            $" Price: {product.Price  }- Snack:{ (product as Snack).Family } ";
                    }
                    else if (product is Drink)
                    {
                        if (product is Food )
                            return $"Products Id: {product.ProductId } - Products Name:{product.Name  } -" +

                                $" Price: {product.Price  }- Food: { (product as Food).Type } ";
                      
                    }
                    if (product is Drink)
                    {
                        return $"Products Id: {product.ProductId } - Products Name:{product.Name  } -" +

                            $" Price: {product.Price  }- Drink:{ (product as Drink).Brand  } ";
                    }

                }
            }
            return null;
        }
        public Dictionary<int, int> Pending(Product product)
        {
            int leftMoney = -product.Price;
            transactionDic.Add(payment, leftMoney);
            return transactionDic;
        }
        public Dictionary<int, int> EndTransaction()
        {
            foreach (Product product in storage)
            {
                if (Purchase(product.ProductId) != null)

                    return Pending(product);

            }

            return null;


        }
        public void InsertMoney(int payment)
        {
            if (payment == 0)
                throw new ArgumentNullException("You Have to insert money first.");
            else
            {

                foreach (int kron in moneyArray)
                {
                    if (payment == kron)
                        moneyPool.Add(payment);
                    else
                        throw new ArgumentException("The inserted Money is not Valid .");



                }

            }
        }
        public Product  Purchase(int Id)
        {
            foreach (Product product in storage)
            {

                if (payment >= product.Price)
                {

                    return product;
                }


            }
            return null;
        }

    }
}

          

    



