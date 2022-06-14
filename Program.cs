// RTFFFFYYUPPPEEEUU
// RTF4YYUP3E3UU

// We ask for the console to the user the characters of the string we are going to compress
// the string will be traked in the string inputCharacters through the Console ReadLine
Console.WriteLine("Please insert the characters");
string inputCharacters = Console.ReadLine();

Console.WriteLine(Result(inputCharacters));

/* The function below receives as a parameter the string that the user created previously,
 we convert the string to Upper Case, also we create an array called chars when we are going to 
convert every character of the string to a char. We add a dictionary to store the characters 
with the value of appearance of each.
*/

char[] Result(string inputCharacters)
{
    string charsToUpper = inputCharacters.ToUpper();
    char[] chars = charsToUpper.ToCharArray();
    Dictionary<char, int> charsToCount = new Dictionary<char, int>();
    
    /*
     with the next foreach we add the characters comming from the chars array 
    to the charsToCount Dictionary
     */
    foreach (char character in chars) 
    {
        if (charsToCount.ContainsKey(character)) //If the character is contained in the dictionary, we just jump to the next index
        {
            charsToCount[character]++;
        }
        else // If the character is new into the dictionary, we add it as a new collection 
        {
            charsToCount.Add(character, 1);
        }
    }
    // Below we create a new array of characters to store the key values of the dictionary previously filled out
    char[] outputCharacters = new char[charsToCount.Count];
    int CountingRep = 0;
    
        foreach (KeyValuePair<char, int> pair in charsToCount) //with this foreach we iterate in the dictionary to extract the keys and the values
    {
        if (pair.Value >= 1 )
        {
            outputCharacters[CountingRep] = pair.Key;
            CountingRep++;
        }
        else
        {
            Array.Resize(ref outputCharacters, outputCharacters.Length - 1);
        }
    }
    return outputCharacters;
}

/*Sorry for not having the exercise resolved as the indications provided, but I felt completly stuck, 
 sincerely the two foreach are brought remembering one class when you showed us how  to resolve an exercise of 
creating a new string without repetitions.
 */