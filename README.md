# PROG6211-
How to compile the software?
You will use Visual Studio to compile the software of the project.

How to run the software and use the software?

You will first have to open up Visual Studio and get the file of the project. Then you will run the project by clicking the  green button in the central once you havre enter the project file.The project will run accrording what is within the project which is :
  
This is structure of how the compile run while the user input values and make choose, how processing is made by the compile and output.

namespace RecipeApp
{
    class Recipe
    {// This where you are declaring the arrays //
        private string name3;
        private int num5Ingredients;
        private string[] ingredients6;
        private int[] quantities5;
        private int[] origQuantities;
        private string[] units9;
        private int numberSteps;
        private string[] steps2;
}

When Visual Studio run the project while compiling the code. This is the first block of code which be run by the code. Which is where the programmer has declare the arrays they are going to use within the project.
 
public Recipe()
        {
            
        }
The code wil first run to gthe main method which is:
class Program
    {
        static void Main(string[] args)
        {// This is an construtor that calls the class of recipe and the methods of the recipe class//
            Recipe recipe = new Recipe();
            //This block of code will display want user wants to do//
            Console.WriteLine("Enter recipe and display recipe type = 1" + "    "+"Enter ingredient quantites be scaling factor (0.5, 2, or 3) type = 2 " + "   " +
                 " " +
                "Enter recipe and display recipe and If you want the ingredient quantites to be reset type = 3 / " + "    " +
                " If want clear all the data and start a new recipe type = 4 / " + "    " +
                "If want to exit the program type = 5 / ");
            int input4 = Convert.ToInt32(Console.ReadLine());
            //this block of code will enable the user enter choose by 1 to 5 //
            int input6 = 1;
            int input7 = 2;
            int input8 = 3;
            int input9 = 4;
            int input10 = 5;
           
            //This block of code contains the if statements that have user choose input methods //
            if (input4 == input6)
            {
                recipe.EnterRecipe();
               
            }
        
           
            if (input4 == input7)
            {
                Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
                double factor = Console.Read();
                recipe.ScaleRecipe(factor);
            }
       
            
            if (input4== input8)
            {

                recipe.ResetQuantities();
            }
          
         
            if (input4 == input9)
            {
                recipe.ClearRecipe();
            }
           
       
            if (input4 == input10)
            {
                Environment.Exit(0);
            }
           


        }
    }
}
 

The main method has the construtor of Recipe which carries the methods that are being called within the if statements occuring the user choose which will called:


1)EnterRecipe()
After running the class Recipe of the declaring arrays , then the compile will run this part of the code where a default constructor of public Recipe is made by the programmer beacause the programmer made this called the methods the programming has made within the code to be capture within the main method.

public void EnterRecipe()
        {
            Console.WriteLine("Enter recipe name:");
            name3 = Console.ReadLine();
            Console.WriteLine("Enter number of ingredients:");
            num5Ingredients = int.Parse(Console.ReadLine());
            ingredients6 = new string[num5Ingredients];
            quantities5 = new int[num5Ingredients];
            origQuantities = new int[num5Ingredients];
            units9 = new string[num5Ingredients];

            for (int j = 0; j < num5Ingredients; j++)
            {
                Console.WriteLine("\nIngredient " + (j + 1) + ":");
                Console.WriteLine("--------------------");
                Console.WriteLine("Enter name of ingredient " + (j + 1) + ":");
                ingredients6[j] = Console.ReadLine();
                Console.WriteLine("Enter quantity of ingredient " + (j+ 1) + ":");
                quantities5[j] = int.Parse(Console.ReadLine());
                origQuantities[j] = quantities5[j];
                Console.WriteLine("Enter unit of measurement for ingredient " + (j + 1) + ":");
                units9[j] = Console.ReadLine();
            }

            Console.WriteLine("\n\nEnter the number of steps:");
            Console.WriteLine("------------------------");
            numberSteps = int.Parse(Console.ReadLine());
            steps2 = new string[numberSteps];

            for (int j = 0; j < numberSteps; j++)
            {
                Console.WriteLine("Enter description of the steps " +" " +(j + 1) + ":");
                steps2[j] = Console.ReadLine();
            }
            Console.WriteLine("Your Recipe you typed: \n");
            Console.WriteLine("Recipe you Name: " + name3);
            Console.WriteLine("Ingredients are:");
            for (int j = 0; j < num5Ingredients; j++)
            {
                Console.WriteLine(" " + quantities5[j] + " " + units9[j] + " of " + ingredients6[j]);
            }
            Console.WriteLine("Steps:");
            for (int j = 0; j < numberSteps; j++)
            {
                Console.WriteLine((j + 1) + ". " + steps2[j]);
            }
        }
After the compile has pass the class Recipe, the compile will run EnterRecipe() , which is a public method that contains the code that the user 
will type in for the recipes. The programmer has made use of Console.WriteLine to print out what is needed to be
 done , using the declare arrays making them eqauling values that use will type
 for example,  num5Ingredients = int.Parse(Console.ReadLine()); and has use the 
for loop to print code neatly and to allow each array to capture to values of the user that have type 
occuring the functions that the programmer ahs for example, capturing the values of the user and putting with each array 
occur to the structure of waht the user needs to do.

2)ScaleRecipe(factor)
public void ScaleRecipe(double factor)
        {
            for (int j = 0; j < num5Ingredients; j++)
            {
                quantities5[j] = (int)Math.Round(quantities5[j] * factor);
            }
        }
After the compile has pass the EnterRecipe() method, the compile will run the ScaleRecipe() method that allow the use
 to either double the factor of the quantities of ingredients or half, this method contains a for loop that will do the math to factor what the user will ask of.

3)ResetQuantities()
Public void ResetQuantities()
        {
            // Reset quantities to their original values
            for (int j = 0; j < num5Ingredients; j++)
            {
                quantities5[j] = origQuantities[j];
            }
        }

After the compile has pass the ScaleRecipe() method , the compile will  run the ResetQuantities()  method which has 
an for loop that equals the what use has factor back to tyhe original value that the user has typed in. 

4)ClearRecipe()
 public void ClearRecipe()
        {
            name3 = null;
            num5Ingredients = 0;
            ingredients6 = null;
            quantities5 = null;
            units9 = null;
            numberSteps = 0;
            steps2 = null;
        }
After the compile has pass the ResetQuantities()  method, the compile will the ClearRecipe() method which contains 
the arrays that was declare in class Recipe to eqaul zero , which clear the values of arrays

4)Environment.Exit(0)
Which exits the program that was running.
