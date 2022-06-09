
Dictionary<int,int> vendingMachine = new Dictionary<int,int>();
vendingMachine.Add(1,20);
vendingMachine.Add(2, 20);
vendingMachine.Add(5,20);
vendingMachine.Add(10,20);
vendingMachine.Add(20,20);

int itemPrice = 0;
int amountOfPayment = 0;



int Transaction(Dictionary<int,int>vendingMachine, int itemPrice, int amountOfPayment)
{
    int amountOfReturn = itemPrice - amountOfPayment;


    return amountOfReturn;
}

