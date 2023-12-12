using System.Xml;

string filePath = "input.txt";
string[] lines = File.ReadAllLines(filePath);
int match = 0;
int pointValue = 0;


foreach (var line in lines)
{
    bool itsAMatch = false;
    var cardInfo = line.Split(":");
    var cardGames = cardInfo[1].Split("|");
    var winningCards = cardGames[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var myCards = cardGames[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
    match = 0;
    


    foreach (var card in myCards)
    {
        
        foreach (var winning in winningCards) 
        {
            if (winning == card)
            {                
                if(itsAMatch) 
                {
                    match = match * 2;
                }
                else
                {
                    match++;
                }
                itsAMatch = true;
                
            }
        }
        
    }
    pointValue += match;
}

// Del 1 Svar
Console.WriteLine("Den totala poängen blir " + pointValue);






























