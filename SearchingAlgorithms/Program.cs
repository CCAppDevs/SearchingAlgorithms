using SearchingAlgorithms;

// linked list (ordered, sorted)

// queue - (ordered by first come, first served)
CustomLinkedList myBBQ = new CustomLinkedList();
int choice = -1;
bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    PrintMenu();
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 0:
            // exit
            isRunning = false;
            break;
        case 1:
            // add an item to the linked list
            Console.Write("What do you want to add to the list?");
            string answer = Console.ReadLine();
            myBBQ.AddToBack(answer);
            PauseForInput();
            break;
        case 2:
            Console.WriteLine(myBBQ.ToString());
            PauseForInput();
            break;
        case 3:
            try
            {
                Console.WriteLine("The first item is: " + myBBQ.Pop());
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            PauseForInput();
            break;
        default:
            Console.WriteLine("Invalid option, please try again.");
            PauseForInput();
            break;
    }
}

static void PauseForInput()
{
    Console.Write("Press any key to continue...");
    Console.ReadLine();
}


static void PrintMenu()
{
    Console.WriteLine("######################################");
    Console.WriteLine("Main Menu");
    Console.WriteLine("######################################");
    Console.WriteLine();
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. Print Contents of List.");
    Console.WriteLine("3. Pop the first item off the list.");
    Console.WriteLine("0. Exit");
    Console.WriteLine();
    Console.Write("What would you like to do? ");
}
