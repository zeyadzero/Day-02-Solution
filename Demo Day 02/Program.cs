namespace Demo_Day_02
{
    class Program
    {
        // Entry Point
        static void Main()
        {

            #region Commment
            // Single Line Comment

            /*
             *  Multi
             *  Line
             *  Comment
             */
            #endregion

            #region DeclareVariable
            //int Id = 10;

            //Console.WriteLine(Id);
            #endregion

            #region ValueType
            //int X;
            //// CLR Will Allocate 4 UnInitialized Bytes at STACK
            //// int : C# Keyword

            //X = 5;

            //Int32 Y = 10;
            //// CLR Will Allocate 4 Initialized Bytes at STACK
            //// Int32 : BCL

            //Y = X; // 5
            //X++;// 6 
            #endregion

            #region CodeSn
            //Console.WriteLine(Y);

            //Console.WriteLine(); //cw

            //for (int i = 0; i < length; i++)
            //{

            //}

            //switch (switch_on) // Tab Tab
            //{
            //    default:
            //}
            #endregion

            #region ReferenceType

            //Point P1;
            //// Declare For Reference Of Type "Point" Refering To Null
            //// This Reference 'P1' Can Refer To An Object From Type 'Point' Or Another Type 'Inheriting' For Type
            //// CLR Will Allocate 4 Bytes For The Reference At STACK
            //// CLR Will Allocate 0 Bytes At HEAP

            //P1 = new Point(); /* Has 2 Reference */
            //// new 
            /////  1.Allocate Required Number Of Bytes With In Heap (Object Size + CLR Ovearhead Variables)
            /////  2. Initalize (Cross Out) Allocated Bytes With Default Value Of Its Datatybe
            /////  3. Call User-Definded Constructor If Exists
            /////  4. Assign The Reference To A Allocated Object The Reference 'P1'

            ////Console.WriteLine(P1.X); //0
            ////Console.WriteLine(P1.Y); //0

            //Point P2 = new Point(); /* Unreachable Object */

            //P2 = P1;

            //P2.X = 10;

            //Console.WriteLine(P1.X); //10

            #endregion

            #region Object

            //object O1;

            //O1 = new object();
            //O1 = "Ahmed";

            //O1 = 5; // Boxing 
            //O1 = 'A';
            //O1 = true;
            //O1 = 3.3;
            //O1 = new DateTime();

            #endregion

            #region Object2
            //object O1 = new Point();

            //O1 = new string("Ahmed");

            ////string X = O1; //error

            //string X = (string)O1; 
            #endregion

            #region Fraction

            //float X = 2.3F; // Defult Double  // 4 byte
            //double Z = 4.34; // 8 byte
            //decimal Y = 9945.6M; //24 byte 
            //// Discard --> Just for Reabilty
            //long Number = 100_000_000_000;

            #endregion

            #region ImplicitCasting VS EXplicitCasting

            #region Part1
            ////int X = 8;
            ////long Y = /*(Long)*/8; //Implicit Casing(Safe Csting)
            ////Console.WriteLine(Y);

            //long X = 8;
            //X = 444444443456546456;
            //int Y = X.GetType() == typeof(int) ? (int)X : 0;
            //Console.WriteLine(Y);

            //checked
            //{
            //    int Y = (int)X; //Explicit Casring(Un Save)
            //    unchecked
            //    {
            //        Console.WriteLine(Y); 
            //    }

            //} 
            #endregion

            #region Part2
            ////int X = 5;
            ////double Y = X; //Implicit Casting
            ////Console.WriteLine(Y);//5

            //double X = 5.5;
            //int Y = (int)X; //Expliicit Casting(Un Safe)
            //Console.WriteLine(Y);//5 
            #endregion
            #endregion

            #region Convert

            ///* Convert --> class Casting Datatype For Other */
            //Console.Write("Please Enter Your Name: ");

            ////string? Name =Console.ReadLine();//Null Or String
            //string Name = Console.ReadLine() ?? "NA";

            //Console.Write("Please Enter Your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please Enter Your Salary: ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 3000);

            //Console.WriteLine("Your Name Is " + Name);
            //Console.WriteLine("Your Age Is " + Age);
            //Console.WriteLine("Your Salary Is " + Salary);



            #endregion

            #region Parse

            //// Parse -->  Method Casting From String To Caller Datatype
            //Console.Write("Please Enter Your Name: ");

            //string Name = Console.ReadLine() ?? "NA";

            //Console.Write("Please Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Please Enter Your Salary: ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.Beep(324, 3000);

            //Console.WriteLine("Your Name Is: " + Name);
            //Console.WriteLine("Your Age Is: " + Age);
            //Console.WriteLine("Your Salary: Is " + Salary);

            #endregion

            #region Convert Parse
            //string X = "5";
            //X = "Ahmed";

            //int Y = int.Parse(X);
            //Console.WriteLine(Y);

            //string X = "true";
            //X = "Hamada";
            //bool flag = Convert.ToBoolean(X);
            //Console.WriteLine(flag); 
            #endregion

            #region TryParse

            //string X = "10";

            //int Y;

            //bool flag = int.TryParse(X, out Y);
            //Console.WriteLine(flag);
            //Console.WriteLine(Y);


            //string X = "Ahmed";

            //int Y;

            //bool flag = int.TryParse(X, out Y);
            //Console.WriteLine(flag);
            //Console.WriteLine(Y); //0

            #endregion

            #region StringFormating

            //int X = 3 , Y = 4;
            //string Message = "Equation: " + X + " + " + Y + " = " + (X + Y);

            //// 1.composite string

            //Message = string.Format("Equation : {0} + {1} = {2}", X, Y, (X + Y));

            //// 2. String Interpolation $ -->Manpulation Opreator

            //Message = $"Equation: {X} + {Y} = {X + Y}";

            //Console.WriteLine(Message);

            #endregion
        }
    }
}
