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
  private static Point point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12;

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
    redCircle.X = (Width-redCircle.Width-text.Width)*2/5;
    text.Location = new Point(redCircle.Right + redCircle.X/2, text.Height);
    redCircle.Y = text.Top-(redCircle.Height-text.Height)/2;
    leftButton.Location = new Point((Width - 2*leftButton.Width)/3, Height/2);
    rightButton.Location = new Point(2*leftButton.Left+rightButton.Width, leftButton.Top);
    point1 = new Point(redCircle.X + redCircle.Width*5/16 , redCircle.Y + redCircle.Height*3/16);
    point2 = new Point(redCircle.X + redCircle.Width/2    , redCircle.Y + redCircle.Height*6/16);
    point3 = new Point(redCircle.X + redCircle.Width*11/16, point1.Y);
    point4 = new Point(redCircle.X + redCircle.Width*13/16, redCircle.Y + redCircle.Height*5/16);
    point5 = new Point(redCircle.X + redCircle.Width*10/16, redCircle.Y + redCircle.Height/2);
    point6 = new Point(point4.X                           , redCircle.Y + redCircle.Height*11/16);
    point7 = new Point(point3.X                           , redCircle.Y + redCircle.Width*13/16);
    point8 = new Point(point2.X                           , redCircle.Y + redCircle.Width*10/16);
    point9 = new Point(point1.X                           , point7.Y);
    point10= new Point(redCircle.X + redCircle.Width*3/16 , point6.Y);
    point11= new Point(redCircle.X + redCircle.Height*6/16, point5.Y);
    point12= new Point(point10.X                          , point4.Y);

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

    Point[] whiteX = {point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12};

    System.Console.WriteLine("Coordinates of point1: X = {0} Y = {1}", whiteX[0].X, whiteX[0].Y);
    System.Console.WriteLine("Coordinates of point2: X = {0} Y = {1}", whiteX[1].X, whiteX[1].Y);
    System.Console.WriteLine("Coordinates of point3: X = {0} Y = {1}", whiteX[2].X, whiteX[2].Y);
    System.Console.WriteLine("Coordinates of point4: X = {0} Y = {1}", whiteX[3].X, whiteX[3].Y);
    System.Console.WriteLine("Coordinates of point5: X = {0} Y = {1}", whiteX[4].X, whiteX[4].Y);
    System.Console.WriteLine("Coordinates of point6: X = {0} Y = {1}", whiteX[5].X, whiteX[5].Y);
    System.Console.WriteLine("Coordinates of point7: X = {0} Y = {1}", whiteX[6].X, whiteX[6].Y);
    System.Console.WriteLine("Coordinates of point8: X = {0} Y = {1}", whiteX[7].X, whiteX[7].Y);
    System.Console.WriteLine("Coordinates of point9: X = {0} Y = {1}", whiteX[8].X, whiteX[8].Y);
    System.Console.WriteLine("Coordinates of point10: X = {0} Y = {1}", whiteX[9].X, whiteX[9].Y);
    System.Console.WriteLine("Coordinates of point11: X = {0} Y = {1}", whiteX[10].X, whiteX[10].Y);
    System.Console.WriteLine("Coordinates of point12: X = {0} Y = {1}", whiteX[11].X, whiteX[11].Y);

    graphics.FillEllipse(Brushes.Red, redCircle);
    graphics.FillPolygon(Brushes.White, whiteX);

    base.OnPaint(e);
  }

  protected void exit(Object sender, EventArgs events)
  {
    System.Console.WriteLine("You clicked on the Exit button. This program will now end.");
    Close();
  }
}
