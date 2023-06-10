using System.Threading.Tasks;

public class TeaMaker
{
    public async Task MakeTeaAsync()
    {
        var buyTeaTask = BuyTheTeaBagAsync();       // 5s
        await WashThePotAsync();                    // 2s
        await FillThePotAsync();                    // 1s
        await WaitForBoilingAsync();                // 5s
        // await BuyTheTeaBagAsync();               // 5s
        // await MakeTheTeaAsync();                 // 1s

        // if(buyTeaTask.IsCompleted)
        // {
        //     await MakeTheTeaAsync();             // 1s
        // }
        // else 
        // {
        //     await buyTeaTask;
        //     await MakeTheTeaAsync();             // 1s
        // }

        await buyTeaTask;
        await MakeTheTeaAsync();
    }

    private async Task BuyTheTeaBagAsync()
    {
        Console.WriteLine("Start buying the teabag...");
        await Task.Delay(5000);
        Console.WriteLine("Finished buying the teabag...");
    }


    private async Task WashThePotAsync()
    {
        Console.WriteLine("Start washing the pot...");
        await Task.Delay(2000);
        Console.WriteLine("Finished washing the pot...");
    }

    private async Task FillThePotAsync()
    {
        Console.WriteLine("Start filling the pot...");
        await Task.Delay(1000);
        Console.WriteLine("Finished filling the pot...");
    }

    private async Task WaitForBoilingAsync()
    {
        Console.WriteLine("Start waiting for boiling...");
        await Task.Delay(5000);
        Console.WriteLine("Finished waiting for boiling...");
    }

    private async Task MakeTheTeaAsync()
    {
        Console.WriteLine("Start making the tea...");
        await Task.Delay(1000);
        Console.WriteLine("Finished making the tea...");
    }
}