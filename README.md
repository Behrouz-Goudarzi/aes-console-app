
# AES Encryption/Decryption Console App

This is a simple and modular C# console application for **AES (Advanced Encryption Standard)** encryption and decryption. It provides a clean interface for securely handling plaintext and encrypted text using a Base64-encoded key and IV.

## Features

- **AES Encryption**: Convert plaintext into ciphertext using AES with user-provided key and IV.
- **AES Decryption**: Recover plaintext from ciphertext using AES.
- **User-Friendly Interface**: Interactive menu system for ease of use.

## Requirements

- **.NET SDK**: Ensure you have the .NET SDK installed.
- **Basic Knowledge**: Understanding of AES encryption and Base64 encoding for keys and initialization vectors.

## Usage

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/Behrouz-Goudarzi/aes-console-app.git
   cd aes-console-app
 

2. **Build the Application**:
   Use an IDE like Visual Studio or the .NET CLI:
   ```bash
   dotnet build
   ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```

4. **Follow the Console Instructions**:
   - Select an operation:
     - `1` for AES Encryption.
     - `2` for AES Decryption.
     - Any other key to quit.
   - Provide the necessary inputs:
     - AES Key (Base64-encoded string).
     - AES Initialization Vector (Base64-encoded string).
     - Plaintext or encrypted text.

## Example Usage

### Encryption
Input:
- **Key**: `Base64EncodedKey`
- **IV**: `Base64EncodedIV`
- **Plain Text**: `Hello, World!`

Output:
- **Encrypted Text**: `EncryptedBase64String`

### Decryption
Input:
- **Key**: `Base64EncodedKey`
- **IV**: `Base64EncodedIV`
- **Encrypted Text**: `EncryptedBase64String`

Output:
- **Plain Text**: `Hello, World!`

## Code Structure

### Main Program
- **Menu-Driven Flow**: The application uses a simple `switch` statement to handle encryption and decryption operations.
- **Helper Methods**:
  - `DisplayMenu`: Displays available operations to the user.
  - `HandleEncryption`: Handles the encryption process, including user input and output display.
  - `HandleDecryption`: Handles the decryption process similarly.
  - `PromptUserInput`: Simplifies input prompts for reuse.
  - `DisplayResult`: Displays successful results with formatting.
  - `DisplayError`: Handles and displays error messages gracefully.

### AES Class
The core encryption and decryption logic is encapsulated in the `AES` class, ensuring:
- **Reusability**: Easily used in other projects.
- **Clarity**: Clean and concise methods for encryption and decryption.

## Contribution

Contributions to improve this project are welcome! Feel free to fork the repository, make changes, and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

---

**Disclaimer**: This application is for educational purposes only. It should not be used in production environments without thorough testing and security improvements.
