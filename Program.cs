Console.WriteLine("Please insert the characters");
string inputCharacters = Console.ReadLine();

Result(inputCharacters);

string Result(string inputCharacters)
{
    string newCharacters = inputCharacters.ToUpper();

    Console.WriteLine(newCharacters);
    return newCharacters;
}


