// Author: Anthony Sam
// Program Name: Mock Error Message

//Name of this file: MockErrorMessageMain.cs
//Purpose of this file: Launch the window showing the form where the label and buttons will be displayed.
//Purpose of this entire program: This program shows a label and two buttons on a Windows Form.

//Source files in this program: MockErrorMessageForm.cs, MockErrorMessageMain.cs
//The source files in this program should be compiled in the order specified below in order to satisfy dependencies.
//  1. MockErrorMessageForm.cs compiles into library file MockErrorMessageForm.dll
//  2. MockErrorMessageMain.cs compiles and links with the dll file above to create MockErrorMessage.exe
//Compile (and link) this file:
//mcs -r:System.Windows.Forms.dll -r:MockErrorMessageForm.dll -out:MockErrorMessage.exe MockErrorMessageMain.cs
//Execute (Linux shell): ./MockErrorMessage.exe

using System.Windows.Forms;

public class MockErrorMessageMain
{
  public static void Main()
  {
    System.Console.WriteLine("The program will begin now.");
    MockErrorMessageForm MockErrorMessage_App = new MockErrorMessageForm();
    Application.Run(MockErrorMessage_App);
    System.Console.WriteLine("The program has ended.");
  }
}
