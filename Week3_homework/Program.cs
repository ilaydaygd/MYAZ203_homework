using Week3_homework;


Product product1 = new Product() { Price = 100, ProductId = 1, ProductName = "Keyboard" };
Product product2 = new Product() { Price = 200, ProductId = 2, ProductName = "Webcam" };
Product product3 = new Product() { Price = 8000, ProductId = 3, ProductName = "Playstation" };
Product product4 = new Product() { Price = 1000, ProductId = 4, ProductName = "Laptop" };


CartItem cart1 = new CartItem() { CartId = 111, Product = product1, Quantity = 3};
CartItem cart2 = new CartItem() { CartId = 222, Product = product2, Quantity = 5 };
CartItem cart3 = new CartItem() { CartId = 333, Product = product3, Quantity = 1 };
CartItem cart4 = new CartItem() { CartId = 444, Product = product4, Quantity = 2 };



ShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.Add(cart1);
shoppingCart.Add(cart2);
shoppingCart.Add(cart3);
shoppingCart.Add(cart4);

shoppingCart.Remove(333);

shoppingCart.GetBalance();
shoppingCart.GetList();

Console.WriteLine(shoppingCart.GetBalance());