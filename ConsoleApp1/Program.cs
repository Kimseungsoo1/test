int[] itemPrices = {100,200,300,400,500};
int totalPrice = 0;

for (int i = 0; i < itemPrices.Length; i++)
{
    totalPrice += itemPrices[i];
}

Console.WriteLine("Total Price: " + totalPrice + "G");