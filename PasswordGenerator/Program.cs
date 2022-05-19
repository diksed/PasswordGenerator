// Passwords are case-sensitive, so we created all the characters that can be used.
string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string smallLetters = "abcdefghijklmnopqrstuvwxyz";
string specialCharacters = "!#$%&'()*+,-./:;<=>?@[]_`{|}~";

// We created string to concatenate all characters.
string password = "";

// We decided to make a 15-letter password.
for (int i = 1; i < 16; i++)
{
    // We choose the type of the next letter.
    Random arrRnd = new Random();
    int arrNum = arrRnd.Next(3);

    // If the number we created from the Random class comes to 2, our next letter will be from specialCharacters
    if(arrNum == 2)
    {
        Random specialRnd = new Random();

        // We chose one of the 29 characters in specialCharacters
        password+=specialCharacters[specialRnd.Next(29)];
    }
    else
    {
        // capitalLetters and smallLetters have 26 letters (means 25 index), this Random class will be chose next letter in capitalLetters or smallLetters. 
        Random lettersRnd = new Random();

        // If the number we created from the Random class comes to 0, our next letter will be from capitalLetters
        if (arrNum == 0)
        {
            password+=capitalLetters[lettersRnd.Next(26)];
        }

        // If the number we created from the Random class comes to 1, our next letter will be from capitalLetters
        else
        {
            password+=smallLetters[lettersRnd.Next(26)];
        }
    }
}

// And our password is ready.
Console.WriteLine($"Your new password:\n{password}");
Console.ReadKey();
