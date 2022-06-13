// RTFFFFYYUPPPEEEUU
// RTF4YYUP3E3UU

// We ask for the console to the user the characters of the string we are going to compress
// the string will be traked in the string inputCharacters through the Console ReadLine
Console.WriteLine("Please insert the characters");
string inputCharacters = Console.ReadLine();

Result(inputCharacters);

/* The function below receives as a parameter the string that the user created previously,
 we convert the string to Upper Case, also we create a string chars when we are going to 
make the output of the new compress characters. There is another string called checkd when 
the values are going to stored when they are not repeated.
With a nested for loop we make a iteration in order to compare the equality of the characters
presented in the string
*/
int Result(string inputCharacters)
{
    int Counter = 0;
    string charsToUpper = inputCharacters.ToUpper();
    string chars = " ";
    string checkd = "";
    
    for (int i=0; i < charsToUpper.Length; i++)
    {
        for (int j = i + 1; j < charsToUpper.Length; j++)
        {
            if (charsToUpper[i] == charsToUpper[j])
            {
                if (!checkd.Contains(charsToUpper[i]))
                {
                    chars += charsToUpper[i];
                    Console.WriteLine(chars);
                }
                
            }
            
        }
        

    }
    

    return Counter;
}

