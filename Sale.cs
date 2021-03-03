using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_System2
{
    class Sale
    {
        Product product;
        Seller seller;

        public string comments;


        Seller[] Sellers = new Seller[20];
        int sellerCount = 0;

        Sale[] Sales = new Sale[100];
        int salesCount = 0;

        Product[] Products = new Product[100];
        int productCount = 0;

        Allocation[] Allocations = new Allocation[20 * 100];
        int allocationCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[salesCount] = newSale;
            salesCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddAllocation(Allocation newAllocation)
        {
            Allocations[allocationCount] = newAllocation;
            allocationCount++;
        }

        public float CountSoldProductPrice()
        {
            float count = 0;
            for(int i = 0; i < productCount; i++)
            {
                count = count + Sales[i].product.price;
            }

            return count;
        }

        public float CountPrice(float sl1,float sl2,float sl3)
        {
            float count = sl1 + sl2 + sl3;
            return count;
        }
    }
}
