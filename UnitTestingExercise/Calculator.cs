using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // DONE - Step 1: Add a reference to your UnitTestingExercise project:

        // DONE - Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // DONE - and add your reference to the UnitTestingExercise project



        // DONE - Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        // DONE - For Example:
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // DONE - Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // DONE - Step 4: 
        // DONE - Create a Subtract method that accepts 2 integers
        // DONE - Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }


        // DONE - Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        // DONE - Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // DONE - Step 8: 
        // DONE - Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        // DONE - Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        // DONE - *****NOW RUN ALL OF YOUR TESTS*********//
    }
}
