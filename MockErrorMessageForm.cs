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

  // This will be used in creating the graphic
  private static Rectangle redCircle = new Rectangle();
  private static Point[] whiteX;

  public MockErrorMessageForm() //this is the constructor
  {
    // Set up texts
    Text = "System Error";
    text.Text = "Bro you just posted cringe!\nYou are going to lose subscriber!";
    text.TextAlign = ContentAlignment.BottomCenter;
    leftButton.Text = "OK";
    rightButton.Text = "Accept";

    // Set up sizes
    Height = 150;
    Width = Height*2;
    text.AutoSize = true;
    redCircle.Size = new Size(leftButton.Height*2, leftButton.Height*2);

    // Set up locations
    redCircle.X = (Width-redCircle.Width-text.Width)/2;
    text.Location = new Point(redCircle.Right, text.Height);
    redCircle.Y = text.Top-(redCircle.Height-text.Height)/2;
    leftButton.Location = new Point((Width - 2*leftButton.Width)/3, Height/2);
    rightButton.Location = new Point(2*leftButton.Left+rightButton.Width, leftButton.Top);

    // Optional stuff
    // leftButton.Enabled = false;  //prevents the left button from being clicked on
    // rightButton.Enabled = false; //prevents the right button from being clicked on

    // Add the created Controls to the Form
    Controls.Add(text);
    Controls.Add(leftButton);
    Controls.Add(rightButton);

    // Tell the events which method to call (The method is defined below)
    leftButton.Click += new EventHandler(exit);
    rightButton.Click += new EventHandler(exit);
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;

    graphics.FillEllipse(Brushes.Red, redCircle);

    base.OnPaint(e);
  }

  protected void exit(Object sender, EventArgs events)
  {
    System.Console.WriteLine("You clicked on the Exit button. This program will now end.");
    Close();
  }
}
