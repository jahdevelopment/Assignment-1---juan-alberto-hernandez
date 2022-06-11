Console.WriteLine("Please enter the price of the product:");
int itemPrice = Int32.Parse(Console.ReadLine());

Console.WriteLine("Please enter the amount of payment:");
int amountOfPayment = Int32.Parse(Console.ReadLine());

Transaction(itemPrice, amountOfPayment);

int Transaction( int itemPrice, int amountOfPayment)
{
    Dictionary<int, int> vendingMachine = new Dictionary<int, int>();
    vendingMachine.Add(20, 24);
    vendingMachine.Add(10, 23);
    vendingMachine.Add(5, 22);
    vendingMachine.Add(2, 21);
    vendingMachine.Add(1, 20);

    int amountOfReturn = amountOfPayment - itemPrice;
    Console.WriteLine(amountOfReturn);

    while (amountOfReturn > 0 && itemPrice != amountOfPayment)
    {
        foreach (KeyValuePair<int, int> item in vendingMachine)

            if (item.Key.Equals(amountOfReturn))
            {
                Console.WriteLine($"the amount of return is: {amountOfReturn}");
                //item.Value-=1;
                Console.WriteLine(item.Value);
                amountOfReturn = 0;
                
            }
            //else if (item.key < amountOfPayment)
            //{

            //}
    }
    return amountOfReturn;
}


    




