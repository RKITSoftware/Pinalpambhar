using System;

namespace StaticClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Inches to Centimeters.");
            Console.WriteLine("2. From Centimeters to Inches.");

            string selection = Console.ReadLine();
            double C, I = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the height in inches: ");
                    C = HeightConvertor.InchesToCentimeters(Console.ReadLine());
                    Console.WriteLine("Hieght in centimeters: {0:F2}", C);
                    break;

                case "2":
                    Console.Write("Please enter the Height in centimeters: ");
                    I = HeightConvertor.CentimetesToInches(Console.ReadLine());
                    Console.WriteLine("Height in Inchs: {0:F2}", I);
                    break;

                default:
                    //read value is lable will ask for valid value
                    ReadValue:
                        Console.WriteLine("Please select a valid convertor.");
                        selection = Console.ReadLine();

                    if (selection == "1") //if selection is 1 control will pass to case 1
                    {
                        goto case "1";
                    }     
                    else if (selection == "2") //if selection is 2 control will pass to case 2
                    {
                        goto case "2";
                    }
                    else //otherwise ask for a valid value
                    {
                        goto ReadValue;
                    }
            }
        }
    }
}
