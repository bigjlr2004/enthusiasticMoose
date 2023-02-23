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

    // MooseSays("Ask me a question.");
    // Console.Write("Question: ");
    // string answer = Console.ReadLine();
    EightBall();

    // CanadaQuestion("Is Canada real?");
    // genericQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    // genericQuestion("Do you love CSharp Yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...!");
    // genericQuestion("Do you want to know a secret??", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
    // genericQuestion("Is Canada Real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();

}

// //Moose Asks A Question
// void EnthusiasticQuestion()
// {
//     MooseSays("Are you enthusiastic?");
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     MooseSays("Do you love C# yet?");
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     MooseSays("Do you want to know a secret?");
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }
// void CanadaQuestion(string question)
// {
//     MooseSays(question);
//     ;
//     bool isTrue = MooseAsks(question);
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I KNEW IT !!!");
//     }
// }

// bool MooseAsks(string question)
// {
//     Console.Write(" (Y/N): ");
//     string answer = Console.ReadLine().ToLower();
//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }
//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }


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

// void genericQuestion(string genericQuestion, string positiveResponse, string negativeResponse)
// {
//     MooseSays(genericQuestion);
//     Console.Write(" (Y/N): ");
//     string answer = Console.ReadLine().ToLower();
//     if (answer == "y")
//     {
//         MooseSays(positiveResponse);
//     }
//     else if (answer == "n")
//     {
//         MooseSays(negativeResponse);
//     }
//     else
//     {
//         MooseSays(genericQuestion);
//     }

// }

void EightBall()
{
    MooseSays("Ask me a question.");
    Console.Write("Question: ");
    string answer = Console.ReadLine();
    if (answer == "")
    {
        return;
    }
    else
    {
        LetsAskThis(answer);
        EightBall();
    }
}

void LetsAskThis(string answer)
{

    if (answer != "")
    {

        Random r = new Random();
        int i = r.Next(0, 14);

        switch (i)
        {
            case 0:
                Console.WriteLine("As I see it, yes.");
                return;
            case 1:
                Console.WriteLine("Ask again later");
                return;
            case 2:
                Console.WriteLine("You may rely on it.");
                return;
            case 3:
                Console.WriteLine("Cannot predict now.");
                return;
            case 4:
                Console.WriteLine("Concentrate and ask again");
                return;
            case 5:
                Console.WriteLine("It is certain");
                return;
            case 6:
                Console.WriteLine("As I see it, yes.");
                return;
            case 7:
                Console.WriteLine("Outlook not so good.");
                return;
            case 8:
                Console.WriteLine("Outlook good.");
                return;
            case 9:
                Console.WriteLine("Reply Hazy Try Again");
                return;
            case 10:
                Console.WriteLine("Without a doubt.");
                return;
            case 11:
                Console.WriteLine("Not today Satan");
                return;
            case 12:
                Console.WriteLine("Yes definitely");
                return;
            case 13:
                Console.WriteLine("Take it to the bank.");
                return;
        }

    }
};
