
string currSeason = GetSeason();

string message = GetSeasonMessage(currSeason);

System.Console.WriteLine(message);

static string GetSeason(){
    System.Console.WriteLine("What season is it? (Winter, Spring, Summer, Fall)");
    
    // Convert to lowecase to make comparison easier
    return Console.ReadLine().ToLower();
}

static string GetSeasonMessage(string season){
    string message;

    if(season == "fall"){
         message = FavoriteSeasonMessage("Sherlenthia");
    }
    else if(season == "winter"){
        message = FavoriteSeasonMessage("Manav");           
    } 
    else{
        message = "It is no ones favorite season";
    }

    return message;
}

static string FavoriteSeasonMessage(string name){
    return $"It is ${name}'s favoite season!";
}