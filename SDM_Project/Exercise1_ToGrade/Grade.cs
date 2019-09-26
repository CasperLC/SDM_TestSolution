using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDM_Project.Exercise1_ToGrade
{
    public class Grade : IGrade
    {
        public int ToGrade(int percentage)
        {
            //Grade Returned
            int grade = -1;
            //Grade -3 Bounds
            int negativeThreeLower = 0;
            int negativeThreeUpper = 5;
            //Grade 0 Bounds
            int zeroLower = 6;
            int zeroUpper = 49;
            //Grade 02 Bounds
            int twoLower = 50;
            int twoUpper = 59;
            //Grade 4 Bounds
            int fourLower = 60;
            int fourUpper = 79;
            //Grade 7 Bounds
            int sevenLower = 80;
            int sevenUpper = 84;
            //Grade 10 Bounds
            int tenLower = 85;
            int tenUpper = 94;
            //Grade 12 Bounds
            int twelveLower = 95;
            int twelveUpper = 100;

            //find grade
            if (percentage < 0)
            {
                throw new InvalidDataException();
            }
            if(percentage>=negativeThreeLower && percentage <= negativeThreeUpper)
            {
                grade = -3;
            }
            if(percentage>=zeroLower && percentage <= zeroUpper)
            {
                grade = 0;
            }
            if (percentage >= twoLower && percentage <= twoUpper)
            {
                grade = 2;
            }
            if (percentage >= fourLower && percentage <= fourUpper)
            {
                grade = 4;
            }
            if (percentage >= sevenLower && percentage <= sevenUpper)
            {
                grade = 7;
            }
            if (percentage >= tenLower && percentage <= tenUpper)
            {
                grade = 10;
            }
            if (percentage >= twelveLower && percentage <= twelveUpper)
            {
                grade = 12;
            }
            if (percentage > 100)
            {
                throw new InvalidDataException();
            }


            return grade;
        }
    }
}
