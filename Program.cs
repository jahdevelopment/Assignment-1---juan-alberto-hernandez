// We start asking the user for the price or the product he wants to buy
// the price will be keept in itemPrice variable and the value will be converted form string to integer
Console.WriteLine("Please enter the price of the product:");
int itemPrice = Int32.Parse(Console.ReadLine());

// Then, we ask for the amount of money how the customer will pay
// The result will be keept in a interger variable called amountOfPayment
Console.WriteLine("Please enter the amount of payment:");
int amountOfPayment = Int32.Parse(Console.ReadLine());

Transaction(itemPrice, amountOfPayment);

/*We are going to create a function called transaction which receive the price of the purchase and the amount of payment.
 Inside we make a dictionary for storing the data about the money avilable in the vending machine.
 The key value stores the value of the coin avilable, The value key stores the quantity of coins of the same value.
 With the amount of pyment we substract the itemPrice to know how much money we need to return to the customer if it's is necessary.
 Using a While loop, we determinate if there is a value to return to the customer, 
 if it's true starts a foreach loop for compare the value of return with each coin availabe to return in the dictionary
 we start searcching of equality from the max value of coin available (tKey) with the value to return,
 if the value is the same we substract a unity of this value stored in the (TValue) and make a return to the customer, 
 in this case the amountOfReturn will be converted to cero.
 In the case of the specification of the first value of a coin (TKey) means less than the value of return, we substract a unity,
 then update the value or return with this amount and start again the loop until we find the amount of return reach cero.
*/
int Transaction( int itemPrice, int amountOfPayment)
{
    Dictionary<int, int> vendingMachine = new Dictionary<int, int>();
    vendingMachine.Add(20, 24);
    vendingMachine.Add(10, 23);
    vendingMachine.Add(5, 22);
    vendingMachine.Add(2, 21);
    vendingMachine.Add(1, 20);

    int amountOfReturn = amountOfPayment - itemPrice;
   
    while (amountOfReturn > 0)
    {
        foreach (KeyValuePair<int, int> item in vendingMachine)

            if (item.Key.Equals(amountOfReturn))
            {
                Console.WriteLine($"the amount of return is: {amountOfReturn}");
                int newValue;
                newValue = item.Value - 1;
                Console.WriteLine("new value: {0}",newValue);
                vendingMachine[item.Key] = newValue;
                amountOfReturn = 0;
                Console.WriteLine(item.Value);
            }
            //else if (vendingMachine[item.Key] < amountOfPayment)
            //{

            //}
    }
    return amountOfReturn;
}


    




