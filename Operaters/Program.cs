using System;
using System.Net;
using System.Runtime.Intrinsics.Arm;
namespace Operaters{
class Program{
    static void Main(string[] args){
        // double a=3.14;
        // // Convert 3.14->3
        // int c=123;
        // double d=Convert.ToDouble(c);
        // int  b=Convert.ToInt32(a);
        // // Convert int to string
        // int e=321;
        // string f=Convert.ToString(e);
        // // Convert string to Char
        // string g="&";
        // char h=Convert.ToChar(g);
        // // Convert string to Char

        // Console.WriteLine(b.GetType());
        // Console.WriteLine(d.GetType());
        // Console.WriteLine(f.GetType());
        // Console.WriteLine(h.GetType());

        // ===============user Input==========================
        //-----Console.ReadLine=input-------
        // System.Console.WriteLine("what your name:");
        // string name=Console.ReadLine();

        // System.Console.WriteLine("what your age:");
        // int age=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Hello\t" + name);
        // Console.WriteLine("You are\t" + age + "Year old");

        //=========================== Arithmetic operators===============================
        // int friend=10;
        // friend =friend+2;
        // friend +=2;
        // friend++;
        // ==========
        // friend =friend-1;
        // frien/ -=2;
        // friend --;
        // ==========
        // friend =friend*2;
        // friend *=2;
        // ==========
        // friend=friend/2;
        // friend/=2;
        // ==========
        // int remainder=friend%3;
        // System.Console.WriteLine(remainder);

        // ==============================================Math class=========================================
        // double x=3.99;
        // double y=5;
        // double a=Math.Pow(x,4);
        // pow =** or 3*3*3 
        // double b=Math.Sqrt(x);
        // qprt = \/-
        // double c=Math.Abs(x);
        // double d=Math.Round(x);
        //Round 3.192->3
        // double f=Math.Ceiling(x);
        //Round 3.192->4
        // double f=Math.Floor(x);
        // Floor 3.99->3
        // double g=Math.Max(x,y);
        // Max find big number 5
        // double g=Math.Min(x,y);
        // // Min small number 3.99
        // // System.Console.WriteLine(a);
        // System.Console.WriteLine(g);

        // ================================================= random numbers=======================================
        // Random  random=new Random();
        // int num= random.Next(1,7);
        // int num1= random.Next(1,7);
        // int num2= random.Next(1,7);
        // // double num=random.NextDouble();
        // System.Console.WriteLine(num);
        // System.Console.WriteLine(num1);
        // System.Console.WriteLine(num2);

        //=====================================================hypotenuse calculator program=============================

        // System.Console.WriteLine("Enter side A:");
        // double a=Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Enter side B:");
        // double b=Convert.ToDouble(Console.ReadLine());
        // double c=Math.Sqrt(a*a + b*b);
        // System.Console.WriteLine("This hypostense is : "+c);
        //======================================================= string methods============================================
        // string fullName="Sun vatank";
        // string phonNumber="1234-5675-786";
        // fullName =fullName.ToUpper();
        // Upper abc ---> ABC
        // fullName =fullName.ToLower();
        // Upper ABC ---> abc

        //  phonNumber= phonNumber.Replace("-","/");
        //  Replace Remove "-" or .. you went and chage to "/" 
        // string frstName=fullName.Substring(0,3);
        // string lastName=fullName.Substring(4,6);

        // System.Console.WriteLine(fullName.Length);

        // System.Console.WriteLine(phonNumber);
        // System.Console.WriteLine(frstName);
        // System.Console.WriteLine(lastName);

        //========================================================== if statements=======================================
        // System.Console.WriteLine("please enter your age:");
        // int age =Convert.ToInt32(Console.ReadLine());
        // if(age>=18){
        //     System.Console.WriteLine("you are now signed up !");
        // }
        // else if(age>100){ 
        //     System.Console.WriteLine("you are too old to singen up!  !");
        // }
        // else if(age<0){ 
        //     System.Console.WriteLine("you hove't been born yet !");
        // }
        // else{
        //     System.Console.WriteLine("you must be 18+ to signed up");
        // }
        // System.Console.WriteLine("plese enter your name:");
        // string name=Convert.ToString(Console.ReadLine());
        // if(name!=""){
        //     System.Console.WriteLine(" hello " + name);

        // }
        // else{
        //     System.Console.WriteLine("you did not enter your name!");
        // }
        //=============================================================================switches ===============================================
        // System.Console.WriteLine("What day is it today?");
        // string day=Console.ReadLine();
        // switch(day){
        //     case "Monday":
        //     System.Console.WriteLine("Is's Monday");
        //     break;
        //     case "Tuesday":
        //     System.Console.WriteLine("Is's Tuesday");
        //     break;
        //     case "Wednasday":
        //     System.Console.WriteLine("Is's Wednasday");
        //     break;
        //     case "Thursday":
        //     System.Console.WriteLine("Is's Thursday");
        //     break;
        //     case "Friday":
        //     System.Console.WriteLine("Is's Friday");
        //     break;
        //     case "Saturday":
        //     System.Console.WriteLine("Is's Saturday");
        //     break;
        //     case "sunday":
        //     System.Console.WriteLine("Is's sunday");
        //     break;
        //     default:
        //     System.Console.WriteLine(day+"is not a day");
        //     break;
        // }
        // ========================================================== logical operators && ||====================================================
        // && AND
        // || (OR)
        // System.Console.WriteLine("what's the tmperature ourtside:(C)");
        // double temp=Convert.ToDouble(Console.ReadLine());
        // if(temp>10 && temp<=25){
        //     System.Console.WriteLine("Is's Warm o utside!");
        // }
        // else if(temp<=-50 || temp>=50){
        //     System.Console.WriteLine("Do Not Go Outdside!");

        // } 
        // ========================================================== while loops=================================================================
        // System.Console.WriteLine("Enter your Nmae:");
        // string Name="";
        // while(Name==""){
        //    System.Console.WriteLine("Enter your Nmae:");
        //     Name=Console.ReadLine();
        // }
        // System.Console.WriteLine("Hello " + Name);
        // ============================================================ for loops=================================================================
        
        // for(int i=0;i<10;i--){
        //     System.Console.WriteLine(i);
        // }
        // System.Console.WriteLine("happy new year!");
        //============================================================= nested loops===================================================================
        // System.Console.WriteLine("How many rows?");
        // int rows=Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("How many Columns?");
        // int Columns=Convert.ToInt32(Console.ReadLine());
        
        // System.Console.WriteLine("What  symblo?");
        // string symblo=Console.ReadLine();
        // for(int i=0;i<rows;i++){
        //     for(int j=0;j<Columns;j++){
        //         System.Console.WriteLine(symblo);
        //     }
        // }
    //      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    //   Console.WriteLine(numbers[0, 1]);
    //=============================================number guessing game ================================
    //    Random  random=new Random();
    //    bool PlayAgain=true;
    //    int  min=1;
    //    int max=100;
    //    int guess;
    //    int number;
    //    int gusses;
    //    string respose;
    //    while (PlayAgain){
    //     guess=0;
    //     gusses=0;
    //     respose="";
    //     number =random.Next(min, max +1);
    //     while (guess!=number){
    //         Console.WriteLine("Gusse a Number between "+min +"-"+max+":");
    //         guess =Convert.ToInt32(Console.ReadLine());
    //         System.Console.WriteLine("Guess:"+ guess);
    //         if(guess>number){
    //             System.Console.WriteLine(guess+"is to hight"); 
    //         }
    //         else if(guess<number){
    //             System.Console.WriteLine(gusses+"is to low!");
    //         }
    //         guess++;
    //     }
    //     System.Console.WriteLine("Number:"+number);
    //     System.Console.WriteLine("YOU WIN!");
    //     System.Console.WriteLine("Gussses"+gusses);
    //     System.Console.WriteLine("woul you like playing ... I guess(Y/N)");
    //     respose=Console.ReadLine();
    //     respose=respose.ToUpper();
    //     if(respose=="Y"){
    //         PlayAgain=true;
    //     }
    //     else{
    //         PlayAgain=false;
    //     }
    //    }
    //    System.Console.WriteLine("Thank you for plying!... I Gusse ");
    //    Console.ReadKey();
    //========================================= Arrays================================
    // string[] Name=new string[3];
    // //  string[] Name={"Vatanak","Nuth","Rong"};
    //  Name[0]="Ta";// cheng Name vatanak to Ta
    //  Name[1]="Min";// cheng Name vatanak to Ta
    //  Name[2]="rak";// cheng Name vatanak to Ta
    // //  Console.WriteLine(Name[0]);//Output Vatannak
    // //  Console.WriteLine(Name[1]);//Output Nuth
    // //  Console.WriteLine(Name[2]);//Output Rong
    // for(int i=0;i<Name.Length;i++){
    //     System.Console.WriteLine(Name[i]);
    // }
    // ========================================  foreach loop =========================
    //  string[] Name={"Vatanak","Nuth","Rong"};
    //  foreach(string i in Name ){
    //     Console.WriteLine(i);
    //  }
    //========================================== methods ===============================
    // string name="Nak";
    // int age=18;
    // singHappyBithday(name,age);

    // static void singHappyBithday( string name,int age){
    //     Console.WriteLine("Happy brithday to you!");
    //     Console.WriteLine("Happy brithday to you!");
    //     Console.WriteLine("Happy brithday to​​​​ Dear" + name);
    //     Console.WriteLine("you are "+age+" years old");
    //     Console.WriteLine("Happy brithday to you!");
    // }
    // ============================================ return keyword==========================
    //  double x;
    //  double y;
    //  double result; 
    //  System.Console.WriteLine("Enter in number1:");
    //  x=Convert.ToDouble(Console.ReadLine());
    //  System.Console.WriteLine("Enter in number2:");
    //  y=Convert.ToDouble(Console.ReadLine());
    //  result=Multply(x,y); 
    //  System.Console.WriteLine("Result:"+result);
    //  static double Multply(double x,double y){
    //  double z=x*y;
    //  return z;
    //    }
    //============================================ method overloading========================
    // double total;
    // total =Multiplay(2,3,4);
    // System.Console.WriteLine(total);
    // Console.ReadKey();
    // }
    // static double Multiplay(double a, double b){
    //     return a*b;
    // }
    // static double Multiplay(double a, double b, double c){
    //     return a*b*c;
    // }
    //============================================= params keyword ============================
    // double total=ChekOut(3.99,6.22,16.33,4);
    // System.Console.WriteLine(total);
    // }
    // static double ChekOut(params double [] prices){
    //     double total=0;
    //     foreach( double price in prices){
    //         total +=price;
            
    //     }
    //     return total;

    // }
    // ============================================== exception handling===========================
    //   double x,y,result;
      // try =try some code that is considered "dagerous"
      // catch =cathes and handles exception whrn they occur
      // finally= always executes regerdless if excption is catght or not
    //   try{
    //   Console.Write("Input Number1:");
    //   x=Convert.ToDouble(Console.ReadLine());
    //   Console.Write("Input Number2:");
    //   y=Convert.ToDouble(Console.ReadLine());
    //   result=x/y;
    //   System.Console.WriteLine("Resule:"+result);
    // }
    // catch(FormatException e){
    //     System.Console.WriteLine("Input Number Please!");
    // }
    // catch(DivideByZeroException e){
    //     System.Console.WriteLine("you can't Divide by  zoro! IDToT!");
    // }
    // catch (Exception e){
    //     System.Console.WriteLine("Erro!");
    // }
    // finally{
    //     System.Console.WriteLine("Thank you!");
    // }
    // =============================================== conditional operator========================
    // conditional operator = used in conditional assigment if a  conditional is true /false
    //(conditional) ? x:y
    // double tmp;
    // Console.Write("Input tmp: ");
    // tmp=
    // Convert.ToDouble(Console.ReadLine());
    // string message;
    // if( tmp >=15){
    //     message="It's warn outside";
    // }
    // else{
    //     message="It's cold outside";

    // }
    // message = (tmp >=15)? "It's warn outside":"It's cold outside";
    // Console.WriteLine(message);
    //================================================= string interpolation =======================
    // string interpolation=allows us to insert varible into a string literal procede a string literal with {} are placeholders
    // string fristName ,lastName;
    // int age;
    // Console.Write("input your frist Name:");
    // fristName=
    // Convert.ToString(Console.ReadLine());
    // Console.Write("input your last name:");
    // lastName=
    // Convert.ToString(Console.ReadLine());
    // Console.Write("Age:");
    // age=
    // Convert.ToInt32(Console.ReadLine());
    // System.Console.WriteLine("Hello"+" "+ fristName +" "+lastname+".");
    // System.Console.WriteLine("You are " + age +" years old!");
    //  ============OR de string interpolation ${}===================
    // System.Console.WriteLine($"Hell {fristName} {lastName}.");
    // System.Console.WriteLine($"You are {age} years old!");
    //==================================================== multidimensional arrays================================
    // string[] Nak={"Nak","F-150","PP"};
    // string[] Nuth={"Nuth","F-160","PV"};
    // string[] Min={"Min","F-170","KC"};
    // string[,]=all
    // string [,] allName={
    //   {"Nak","F-150","PP"},
    //   {"Nuth","F-160","PV"},
    //   {"Min","F-170","KC"}
    // };
    // allName[0,2]="KT";
    // allName[2,0]="Rong";
    // // foreach (string i in allName){
    // //   Console.WriteLine(i);
    // // }
    // //====== use for loop====
    // for(int i=0;i<allName.GetLength(0);i++){
    //   for(int j=0;j<allName.GetLength(1);j++){
    //     Console.Write(allName[i,j]+" ");
    //   }
    //   System.Console.WriteLine();
    // }
    //==================================================== classes (OOP)=================================
    // class =A  bundle of relate code can be as a bluprint to create nobject (OOP)
    // call Class_Call.cs
    // class_Call.Hello();
    // class_Call.Waiting();
    // class_Call.Bey();
    //=====================================================  objects ====================================
    

    }
  
} 
}  