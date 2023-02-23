using System;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
Console.WriteLine("We are Happy You ARE Here!!!!!    ");
Console.WriteLine();
Console.WriteLine();

//Moose Speaks
MooseSays("HEY, I'm an ehtusiastic moose WOOT WOOT!!");
MooseSays("NO REALLY I AM!!!!!! ENTHUSIASTIC!!!!");
MooseSays("Is Canada real?");
//Moose Asks A Question
string question = "Is Canada real?";
bool isTrue = MooseAsks(question);
if (isTrue)
{
    MooseSays("Really? It seems very unlikely.");
}
else
{
    MooseSays("I KNEW IT !!!");
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |x \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write(" (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}