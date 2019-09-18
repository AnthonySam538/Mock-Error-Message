// Author: Anthony Sam
// Program Name: Mock Error Message

//Name of this file: MockErrorMessageForm.cs
//Purpose of this file: Define the layout of the user interface (UI) window.
//Purpose of this entire program: This program shows a label and two buttons on a Windows Form.

//Source files in this program: MockErrorMessageForm.cs, MockErrorMessageMain.cs
//The source files in this program should be compiled in the order specified below in order to satisfy dependencies.
//  1. MockErrorMessageForm.cs compiles into library file MockErrorMessageForm.dll
//  2. MockErrorMessageMain.cs compiles and links with the dll file above to create MockErrorMessage.exe
//Compile this file:
//mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -out:MockErrorMessageForm.dll MockErrorMessageForm.cs

using System;
using System.Windows.Forms;
using System.Drawing;

public class MockErrorMessageForm : Form
{
  // Create Controls
  private static Label text = new Label();
  private static Button leftButton = new Button();
  private static Button rightButton = new Button();

  public MockErrorMessageForm() //this is the constructor
  {
    // Set up the form/window
    Text = "Warning";
    Height = 150;
    Width = Height*2;

    // Initialize Controls
    text.Text = "Bro you just posted cringe!\nYou are going to lose subscriber!";
    text.Width = Width;
    text.Top = text.Height;
    text.TextAlign = ContentAlignment.MiddleCenter;

    leftButton.Text = "OK";
    leftButton.Location = new Point((Width - 2*leftButton.Width)/3, Height/2);
    // leftButton.Enabled = false;  //disabling this button is optional

    rightButton.Text = "Accept";
    rightButton.Location = new Point(2*leftButton.Left+rightButton.Width, leftButton.Top);
    // rightButton.Enabled = false; //disabling this button is also optional

    // Add the created Controls to the Form
    Controls.Add(text);
    Controls.Add(leftButton);
    Controls.Add(rightButton);
    
    // Tell the events which method to call (The method is defined below)
    leftButton.Click += new EventHandler(exit);
    rightButton.Click += new EventHandler(exit);
  }
  
  protected void exit(Object sender, EventArgs events)
  {
    System.Console.WriteLine("You clicked on the Exit button. This program will now end.");
    Close();
  }
}
