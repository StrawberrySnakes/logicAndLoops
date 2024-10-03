//Dessa Shapiro
namespace LogicAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varables 
            string playerName = "advanturer";
            string userChoice = "None";
            Console.Write("Welcome to the game strange unknown creature\nBut remember, life is not a game\nTis but a crule reality.");
            Console.WriteLine("What are the words they call you by stanger? (Type your name then hit ENTER): ");
            playerName = Console.ReadLine();
            Console.WriteLine("What an unfortonite title you've revieved " + playerName + ", but I suppose there's no helping it\nIt is time to begin your jouney...");
            Console.WriteLine("You awake to find yourself alone in the forest.\nThe sounds to squaking birds infulare your ears and you look around in a daze.\nYou look around and find a rope on your left and a bottle of water on your right.\nWhich one do you pick up?(Type R for the rope and W for the water):");
            userChoice = Console.ReadLine();
            Console.WriteLine("You choose "+ userChoice);

            //Check what userchoice is
            if (userChoice == "R")
            {
                Console.WriteLine("You grab the rope and begin to walk through the forest. You eventually reach a cliff.\nYou use the rope to scale the ciff making it out of the forest.\nYou are safe but it's been days since you've had a sip of water.\nYou colapse of dehydration... ");
            }
            else if (userChoice == "W")
            {
                Console.WriteLine("You grab the bottle of water. You eventually reach a cliff.\nYou sit there stupified on how you will climb it.\nYou try your best, but you're not rock climber... and fall to your doom...\nAt least you were hydrated when you died");

            }
            //you could also use functions to do this as well
            else {
                while (userChoice != "R" && userChoice != "W" && userChoice != "N") {
                    Console.WriteLine("That was not an option :(");
                    Console.WriteLine("To continue (Type R for the rope,  W for the water or N for a secret option): ");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("You choose " + userChoice);
                };
                //if you pick rope
                if (userChoice == "R")
                {
                    Console.WriteLine("You grab the rope and begin to walk through the forest. You eventually reach a cliff.\nYou use the rope to scale the ciff making it out of the forest.\nYou are safe but it's been days since you've had a sip of water.\nYou colapse of dehydration... ");
                }
                //if you pick water
                else if (userChoice == "W")
                {
                    Console.WriteLine("You grab the bottle of water. You eventually reach a cliff.\nYou sit there stupified on how you will climb it.\nYou try your best, but you're not rock climber... and fall to your doom...\nAt least you were hydrated when you died");
                }
                //secret option
                else if (userChoice == "N")
                {
                    Console.WriteLine("You decide to be a rebel and don't take either. You wander the forest aimlesly.\nJust as you see a clearing into a town a giant bird grabs you.\nThe birsd take you to it's nest and feeds you to it's babies");
                }
                else
                {
                    Console.WriteLine("HMMMMMMMMM");
                }
                //it stops here
            }

        }
    }
}
