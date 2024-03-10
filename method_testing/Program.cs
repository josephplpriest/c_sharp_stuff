Random dice = new();

List<decimal> nums = [];

int counter = 0;

while (!Console.KeyAvailable) {
    counter += 1;

    decimal roll = dice.Next(1,7);


    Console.WriteLine($"You've rolled a {roll}");
    
    Thread.Sleep(1000);

    nums.Add(roll);

}

Console.WriteLine($"The average of your {counter} rolls was: {nums.Average()}");