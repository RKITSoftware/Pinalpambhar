using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClass_Demo
{
    public static class HeightConvertor
    {

        #region Method: InchesToCentimeters

        /*static method InchesToCentimeters() to convert Height in Inches to Centimeters
         this method takes height in Inches as a parameter
         and return centimeters as an output*/
        public static double InchesToCentimeters(string HeightInInches)
        {
            double inches = Double.Parse(HeightInInches);
            double Centimeters = (inches * 2.54);
            return Centimeters;
        }
        #endregion Method: InchesToCentimeters

        #region Method: CentimetesToInches
        /*static method CentimetesToInches to convert Height in Centimeters to Inches
         this method takes height in Centimeters as a parameter
         and return Inches as an output*/
        public static double CentimetesToInches(string HeightInCentimeters)
        {
            double centimeters = Double.Parse(HeightInCentimeters);
            double Inches = (centimeters / 2.54);
            return Inches;
        }
        #endregion Method: CentimetesToInches
    }
}
