namespace Cart.Item
{
    public class ShoppingItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
    }

    //initialize data for testing
    public static class ItemName
    {
        public static string OrangeName = "Orange";

    }
    public static class ItemCategory
    {
        public static string OrangePrice = "Fruit";

    }

    public static class ItemPrices
    {
        public static decimal OrangePrice = 10;

    }


}
