//start main

WelcomeUser();
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumRecommendations(enjoymentLevel, stadium, game);

//end main

static void WelcomeUser()
{
    System.Console.WriteLine("Hello and welcome to the College Football Intro application!\nI'll help you decide the stadium in which you'll attend your VERY FIRST GAME!!");
}

static string GetEnjoymentLevel()
{
    System.Console.WriteLine("\n\nWhat level of enjoyment would you like to experience at your first game?\nOptions: Boring, Average, Fun, Epic");
    return Console.ReadLine();
}

static string GetStadiumRecommendation(string enjoymentLevel)
{
    if (enjoymentLevel.ToLower() == "boring")
    {
        return "Neyland Stadium";
    }
    else if (enjoymentLevel.ToLower() == "average")
    {
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel.ToLower() == "fun")
    {
        return "Tiger Stadium";
    }
    else if (enjoymentLevel.ToLower() == "epic")
    {
        return "Saban Field at Bryant-Denny Stadium";
    }
    else
    {
        return "invalid input";
    }
    
}

static string GetGameRecommendation(string stadium)
{
    if (stadium == "Neyland Stadium")
    {
        return "vs. Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium")
    {
        return "vs. Kentucky";
    }
    else if (stadium == "Tiger Stadium")
    {
        return "vs. Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium")
    {
        return "vs. Auburn";
    }
    else
    {
        return "invalid input";
    }
}

static void DisplayStadiumRecommendations(string enjoymentLevel,string stadium, string game)
{
    Console.Clear();
    System.Console.WriteLine($"You're wanting a(n) {enjoymentLevel} experience, so we recommend going to {stadium} to watch a game {game}.");
}


