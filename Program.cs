using AESConsoleApp;

        while (true)
        {
            DisplayMenu();
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    HandleEncryption();
                    break;
                case "2":
                    HandleDecryption();
                    break;
                default:
                    return;
            }
        }

#region Helper
static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Select Operation:");
        Console.WriteLine("1. AES Encrypt");
        Console.WriteLine("2. AES Decrypt");
        Console.WriteLine("Any other key to Quit.");
    }

     static void HandleEncryption()
    {
        Console.Clear();
        Console.WriteLine("AES Encryption");
        Console.WriteLine("Note: Key and Initialization Vector (IV) must be Base64 strings.");

        var key = PromptUserInput("Enter AES Key:");
        var iv = PromptUserInput("Enter AES Initialization Vector (IV):");
        var plainText = PromptUserInput("Enter Plain Text:");

        try
        {
            var encryptedText = AES.Encrypt(plainText, key, iv);
            DisplayResult("Encrypted Text:", encryptedText);
        }
        catch (Exception ex)
        {
            DisplayError(ex.Message);
        }
    }

     static void HandleDecryption()
    {
        Console.Clear();
        Console.WriteLine("AES Decryption");
        Console.WriteLine("Note: Key and Initialization Vector (IV) must be Base64 strings.");

        var key = PromptUserInput("Enter AES Key:");
        var iv = PromptUserInput("Enter AES Initialization Vector (IV):");
        var encryptedText = PromptUserInput("Enter Encrypted Text:");

        try
        {
            var decryptedText = AES.Decrypt(encryptedText, key, iv);
            DisplayResult("Decrypted Text:", decryptedText);
        }
        catch (Exception ex)
        {
            DisplayError(ex.Message);
        }
    }

     static string PromptUserInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

     static void DisplayResult(string label, string result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{label} {result}");
        Console.ResetColor();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

     static void DisplayError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error: {message}");
        Console.ResetColor();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
#endregion




