var weather = new Weather();

await Start();

async Task Start()
{
    while(true)
    {
        ShowMenu();
        if(false == int.TryParse(Console.ReadLine(), out var menuInput))
        {
            ShowError("Noto'g'ri tanlov, qayta tanlang!");
            continue;
        }

        switch(menuInput)
        {
            case 1: await SelectCityAsync(); break;
            case 2: await ShowAllCitiesAsync(); break;
            case 3: await ShowRandomCityAsync(); break;
            case 4: return;
            default: ShowError("Noto'g'ri tanlov, qayta tanlang!"); break;
        }
    }
}

Task ShowRandomCityAsync()
{
    Console.Clear();
    return weather.PrintRandomCityAsync();
}

Task ShowAllCitiesAsync()
{
    Console.Clear();
    return weather.PrintAllCitiesAsync();
}

Task SelectCityAsync()
{
    Console.Clear();
    while(true)
    {
        ShowCities(Weather.CityNames);

        var cityInput = Console.ReadLine();

        if(int.TryParse(cityInput, out var city))
        {
            if(city < 1 || city > Weather.Cities.Count())
            {
                ShowError($"{1} va {Weather.Cities.Count()} oralig'ida shaxar raqamini tanlang!");
                continue;
            }
            
            return weather.PrintSingleCityAsync(city);
        }

        if(Weather.CityNames.Any(c => string.Equals(c, cityInput, StringComparison.InvariantCultureIgnoreCase)))
            return weather.PrintSingleCityAsync(cityInput);

        ShowError($"Shaxar nomini noto'g'ri kiritdingiz!");
    }
}

void ShowError(string message)
{
    Console.Clear();
    var color = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = color;
}

void ShowMenu()
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Menyuni tanlang: ");
    Console.WriteLine();
    Console.WriteLine("1. Shahar tanlash");
    Console.WriteLine("2. Hamma shaharlar");
    Console.WriteLine("3. Tasodifiy shahar");
    Console.WriteLine("4. Chiqish");
    Console.WriteLine("---------------------------");
    Console.Write("Tanlang: ");
}

void ShowCities(IEnumerable<string> cityNames)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Shaxarni tanlang: ");
    var index = 1;
    cityNames.ToList().ForEach(x => Console.WriteLine($"{index++}. {x}"));
    Console.WriteLine("---------------------------");
    Console.Write("Tanlang: ");
}