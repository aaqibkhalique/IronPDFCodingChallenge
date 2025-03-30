# IronPDFCodingChallenge

## Author: AAQIB KHALIQUE

This project implements a T9-style Old Phone Pad decoder in C# as part of the IronPDFCodingChallenge.

## 📌 Features
- Converts numeric key presses to text.
- Supports backspace (`*` key) for corrections.
- Supports spaces (`0` key) for word separation.
- Ignores invalid inputs and ensures proper formatting.

## 📌 Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/aaqibkhalique/IronPDFCodingChallenge.git
   ```
2. Open the solution in **Visual Studio**.
3. Run the application or execute unit tests.

## 📌 Usage
```csharp
string result = Phone.OldPhonePad("2 2 77 444 22#");
Console.WriteLine(result); // Output: AAQIB
```

## 📌 Running Tests
1. Open **Test Explorer** (`Test > Test Explorer`).
2. Click **Run All** to execute tests.
