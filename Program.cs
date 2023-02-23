using System;
Main();
void Main()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

    Console.WriteLine();
    Console.WriteLine();

    //Moose Speaks
    MooseSays("HEY, I'm an enthusiastic moose WOOT WOOT!!");
    MooseSays("NO REALLY I AM!!!!!! ENTHUSIASTIC!!!!");
    CanadaQuestion("Is Canada real?");
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
    Console.WriteLine("We are Happy WE ARE Here!!!!!    ");
}

//Moose Asks A Question
void EnthusiasticQuestion()
{
    MooseSays("Are you enthusiastic?");
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    MooseSays("Do you love C# yet?");
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    MooseSays("Do you want to know a secret?");
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}
void CanadaQuestion(string question)
{
    MooseSays(question);
    ;
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I KNEW IT !!!");
    }
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