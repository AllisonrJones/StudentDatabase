




//          1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food".Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)
//        1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.

string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

bool run = true;
bool interloop = false;
bool valid = true;

do
{
    Console.WriteLine("Would you like to search a student by number, or name?");
    string firstCall = Console.ReadLine();
   
        Console.WriteLine("Which student would you like to know more about 1-16?");
        int prompt1 = int.Parse(Console.ReadLine());


        do
        {
            if (prompt1 < 1 || prompt1 > names.Length)
            {
                Console.WriteLine("That value is outside of our index range. Please enter a value between 1-16:");
                prompt1 = int.Parse(Console.ReadLine());

            }
        } while (valid != true);
    
   
      Console.WriteLine("student " + (prompt1) + " is " + names[prompt1]);
      Console.WriteLine("What would you like to know? Enter 'Hometown', or 'Favorite Food':");
      string prompt2 = Console.ReadLine().ToLower();

        do
        {
            if (prompt2 == "hometown")
            {
                Console.WriteLine(names[prompt1] + " is from " + towns[prompt1]);
                break;
            }
            else if (prompt2 == "favorite food")
            {
                Console.WriteLine(names[prompt1] + "'s favorite food is " + foods[prompt1]);
                break;
            }
            else
            {
                Console.WriteLine("Please provide a valid response");
            }
        } while (interloop == true);



        Console.WriteLine("Would you like to learn about another student?");
        Console.WriteLine("Enter 'y' or 'n':");
        string responses = Console.ReadLine().ToLower();

        if (responses == "y")
        {
            run = true;
        }
        else if (responses == "n")
        {
            run = false;
        }
        else
        {
            Console.WriteLine("Let's start at the top");
        }
    
 

} while (run == true);
Console.WriteLine("Before you go would you like a list of all students?");
string fullList = Console.ReadLine();

if(fullList=="yes" || fullList == "y")
{
    foreach(string person in names)
    {
        Console.WriteLine(person);
    }
}
else
{
    Console.WriteLine("Have a good day");
}




//prompt3