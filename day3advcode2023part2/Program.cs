using System.Xml;
// Denna uppgift inte färdig ännu
string filePath = "input.txt";
string[] lines = File.ReadAllLines(filePath);
int match = 0;
int pointValue = 0;


foreach (var line in lines)
{
    
    var cardInfo = line.Split(":");
    var cardGames = cardInfo[1].Split("|");
    var winningCards = cardGames[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var myCards = cardGames[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
    match = 0;
    int copiesCount = 0;


    foreach (var card in myCards)
    {

        foreach (var winning in winningCards)
        {
            if (winning == card)
            {
                copiesCount++;
            }
        }

    }
    
}


