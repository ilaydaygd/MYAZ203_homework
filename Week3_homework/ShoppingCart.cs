using System.Xml.Schema;
using Week3_homework;

namespace Week3_homework;

public class ShoppingCart
{
    private List<CartItem> cartItems;

    public ShoppingCart()
    {
        cartItems = new List<CartItem>();
    }

    public void Add(CartItem cartItem)
    {
        cartItems.Add(cartItem);
    }

    public void Remove(int id)
    {
        var removed = cartItems.FirstOrDefault(x => x.CartId == id);
        if (removed == null)
        {
            Console.WriteLine($"Not found.");
            return;
        }
        cartItems.Remove(removed);
      
    }

    public string GetBalance()
    {
        double price = 0;
      foreach (var item in cartItems)
        {
            price += item.Product.Price * item.Quantity;
        }
        return ($"Total Price: {price} ");
        
    }

    public void GetList()
    {
        foreach(var cartItem in cartItems)
        {
            Console.WriteLine(cartItem);
        }
    }

}