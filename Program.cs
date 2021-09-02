using System;
using System.Collections.Generic;

namespace HW1ทดลอง
{
    class T_shirt
    {
        public string size;
        public string color;
        public float price;
        public string image;
        

        public T_shirt(string valuesize, string valuecolor, float valueprice, string valueimage)
        {
            size = valuesize;
            color = valuecolor;
            price = valueprice;
            image = valueimage;
        }
    }

    class User
    {
        public string name;
        public string email;
        public ShoppingCart ShoppingCarts;
        public User(string valuname, string valueemail,ShoppingCart valueShoppingcart)
        {
            name = valueemail;
            email = valueemail;
            ShoppingCarts = valueShoppingcart;
        }
    }

    class Address
    {
        public string street;
        public string city;
        public string zipCode;
        public Address(string valuestreet, string valuecity, string valuezipcode)
        {
            street = valuestreet;
            city = valuecity;
            zipCode = valuezipcode;
        }
    }

    class ShoppingCart
    {
        public Address address;
        public float Totalcost = 0;
        private List<T_shirt> orderTShirt;
        
        public ShoppingCart()
        {

            orderTShirt = new List<T_shirt>();    
        }
        
        public void addTshirt(T_shirt valuetshirt)
        {
            orderTShirt.Add(valuetshirt);
        }


        public void total_cost()
        {
            foreach(T_shirt shirt in orderTShirt)
            {
                Totalcost = Totalcost + shirt.price;
            }
            Console.WriteLine(Totalcost);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {   
            ShoppingCart all = new ShoppingCart();
            
            Address jamesaddress = new Address("Phutthamonthon", "Nakhon Pathom", "10180");
           
            User jame = new User("Jame Watson", "jame@gmail.com",all);
            
            T_shirt shirt1 = new T_shirt("L","Red",500,"ABC");
            T_shirt shirt2 = new T_shirt("M", "Black", 750, "DEF");
            T_shirt shirt3 = new T_shirt("S", "White", 625, "GHI");
           
            all.address = jamesaddress;
            
            jame.ShoppingCarts.addTshirt(shirt1);
            jame.ShoppingCarts.addTshirt(shirt2);
            jame.ShoppingCarts.addTshirt(shirt3);
            jame.ShoppingCarts.total_cost();
        }
    }
}
