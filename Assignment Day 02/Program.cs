using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Day_02
{
    class Program
    {
        static void Main()
        {
            #region 1-	Write a program that allows the user to enter a number then print it.

            //int Number;

            //Console.Write("Please Enter The Number: ");

            //Number = Convert.ToInt32(Console.ReadLine() ?? "Null");

            //Console.Clear();

            //Console.WriteLine($"Your Number Is: {Number} ");

            #endregion

            #region 2-	Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //string Name = "Zeyad";
            //int Number;

            //int.TryParse(Name, out Number);

            //Console.WriteLine(Number); /*Return 0*/

            //Number = int.Parse(Name);
            //Console.WriteLine(Number); /* System.FormatException: 'The input string 'Zeyad' was not in a correct format.'*/

            #endregion

            #region 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float Number1 = 20.5f, Number2 = 17.3f;

            //Console.WriteLine($"Equation: {Number1} + {Number2} = {Number1 + Number2}");
            //Console.WriteLine($"Equation: {Number1} - {Number2} = {Number1 - Number2}");
            //Console.WriteLine($"Equation: {Number1} * {Number2} = {Number1 * Number2}");
            //Console.WriteLine($"Equation: {Number1} / {Number2} = {Number1 / Number2}");
            //Console.WriteLine($"Equation: {Number1} % {Number2} = {Number1 % Number2}");


            #endregion

            #region 4-	Write C# program that Extract a substring from a given string.

            //string Name = "Zeyad Hossam" , SubString;

            //SubString = Name.Substring(6, 6); //// (Index , Length)

            //Console.WriteLine($"Name: {Name} ");
            //Console.WriteLine($"Ectract Substring: {SubString} ");
            #endregion

            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int Number1 = 5 , Number2 = 10;

            //Number1 = Number2;

            //Number2 = 25;

            //Console.WriteLine($"Number1 is: {Number1} "); ////10
            //Console.WriteLine($"Number2 is: {Number2} "); ////25

            ///*Here change is based on value not in reference*/

            #endregion

            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Reference R1 = new Reference();
            //Reference R2 = new Reference();

            //R1.Number1 = 5;
            //R1.Number2 = 10;

            //R2 = R1;

            //R1.Number1 = 25;
            //R2.Number2 = 35;

            //Console.WriteLine($"Number1 is: {R1.Number1} "); //25
            //Console.WriteLine($"Number2 is: {R1.Number2} "); //35
            //Console.WriteLine($"Number1 is: {R2.Number1} "); //25
            //Console.WriteLine($"Number2 is: {R2.Number2} "); //35

            /////*Here change is based on reference*/

            #endregion

            #region 7-	Write C# program that take two string variables and print them as one variable 

            //string FirstName, LastName, FullName;

            //Console.Write("Please Enter Your First Name: ");
            //FirstName = Console.ReadLine() ?? "Null";
            //Console.Write("Please Enter Your Last Name: ");
            //LastName = Console.ReadLine() ??  "Null";
            //FullName = $"{FirstName} {LastName}";
            //Console.WriteLine($"Your FullName Is {FullName} ");


            #endregion

            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is  Interest = (principal * rate * time) / 100.

            //double SimpleInetrest, PrincipalAmount, RateOfInterest, Time;

            //Console.Write("Please Enter Principal Amount: ");
            //PrincipalAmount = double.Parse(Console.ReadLine() ?? "Null");
            //Console.Write("Please Enter Rate Of Interest: ");
            //RateOfInterest = double.Parse(Console.ReadLine() ?? "Null");
            //Console.Write("Please Enter Time: ");
            //Time = double.Parse(Console.ReadLine() ?? "Null");

            //SimpleInetrest = (PrincipalAmount * RateOfInterest * Time) / 100;

            //Console.Clear();

            //Console.WriteLine($"Simple Interest Is: {SimpleInetrest} ");    

            #endregion

            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI isBMI = (Weight) / (Height * Height)

            //double BMI, Weight, Height;

            //Console.Write("Please Enter Your Weight In Killograms: ");
            //Weight = double.Parse(Console.ReadLine() ?? "Null");
            //Console.Write("Please Enter Your Height In Meters: ");
            //Height = double.Parse(Console.ReadLine() ?? "Null");

            //BMI = (Weight) / (Height * Height);

            //Console.Clear();

            //Console.WriteLine($"Your BMI Is: {BMI} ");

            #endregion

            #region 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //double Tempreature;
            //string Message;

            //Console.Write("Please Enter The Tempreature: ");
            //Tempreature = double.Parse(Console.ReadLine() ?? "Null");

            //Message = Tempreature < 10 ? "Just Cold" : Tempreature > 30 ? "Just Hot" : "Just Good";

            //Console.WriteLine($"Tempreature Is {Message} ");

            #endregion

            #region 11-	Write a program that takes the date from user and displays it in various formats using string interpolation.Ex:  Today’s date : 20 , 11 , 2001 Today's date : 20 / 11 / 2001 Today's date : 20 – 11 – 2001

            //DateTime Date;

            //Console.Write("Please Enter The Date: ");

            //Date = DateTime.Parse(Console.ReadLine()?? "Null");

            //Console.WriteLine($"Date : {Date.ToString ("dd , MM , yyyy")}");
            //Console.WriteLine($"Date : {Date.ToString("dd / MM / yyyy")}");
            //Console.WriteLine($"Date : {Date.ToString("dd - MM - yyyy")}");


            #endregion

            #region 12-	 What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");


            ///* c)	 The event is on 06/14/2024 */


            #endregion

            #region 13-	Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            ///* f)	A value 1 will be assigned to d.*/


            #endregion

            #region 14-	Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            ///* d)	6 1 */

            #endregion

            #region 15-What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z); ////2+5 7   7 7
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            ///* d)	7 7 */


            #endregion
        }
    }
}
