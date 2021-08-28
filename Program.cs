using System;
using System.Collections.Generic;

namespace Homework_Class
{   class Tshirt
    {
        public string size;
        public string color;
        public float cost;
        public string image;

        public Tshirt(string valueSize, string valueColor, float valueCost, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            cost = valueCost;
            image = valueImage;
        }
    }
    class User 
    {
        public string name;
        public string email;
        public ShoppingCart shoppingcart;

        public User(string valueName, string valueEmail, ShoppingCart valueShoppingCart)
        {
            name = valueName;
            email = valueEmail;
            shoppingcart = valueShoppingCart;
        }

    }
    class Address 
    {
        public string street;
        public string city;
        public string zipcode;

        public Address(string valueStreet, string valueCity, string valueZipcode) 
        {
            street = valueStreet;
            city = valueCity;
            zipcode = valueZipcode;
        }
    }

    class ShoppingCart 
    {
        public float totalCost = 0;
        public Address address;
        private List<Tshirt> orderTshirt;

        public ShoppingCart(Address valueAddress) 
        {
            orderTshirt = new List<Tshirt>();
            address = valueAddress;
        }
        public void addTshirt(Tshirt tShirt)
        {
            orderTshirt.Add(tShirt);
        }
        public void showTotalCost() 
        {
            foreach(Tshirt tshirt in orderTshirt)
            {
                totalCost += tshirt.cost;
            }
            Console.WriteLine(totalCost);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Address addressJame = new Address("131/75 พุทธมณฑล", "นครปฐม", "10180");
            ShoppingCart shoppingcartJame = new ShoppingCart(addressJame);

            User jame = new User("Jame", "jame@gmail.com",shoppingcartJame);

            Tshirt tshirt_1 = new Tshirt("L","Red",500f,"Image1");
            Tshirt tshirt_2 = new Tshirt("M","Black",750f,"Image2");
            Tshirt tshirt_3 = new Tshirt("S","Black",625f,"Image3");

            jame.shoppingcart.addTshirt(tshirt_1);
            jame.shoppingcart.addTshirt(tshirt_2);
            jame.shoppingcart.addTshirt(tshirt_3);

            jame.shoppingcart.showTotalCost();

        }
    }
}
