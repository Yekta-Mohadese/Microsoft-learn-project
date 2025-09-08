using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net;

public class Program
{
    public static async Task Main(string[] args)
    {
        Program program = new Program();
        Task task1 = program.DownloadDataAsync1();
        Task task2 = program.DownloadDataAsync2();
        await Task.WhenAll(task1, task2);
        Console.WriteLine("all downloads completed.");
    }

    public async Task DownloadDataAsync1()
    {
        try
        {
            Console.WriteLine("this is  test message.");
            throw new InvalidOperationException("simulated download error.");
            await Task.Delay(5000);
            Console.WriteLine("this is another test message.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occurred:" + ex.Message); 
        }
    }
    public async Task DownloadDataAsync2()
    {
        
            Console.WriteLine("first download has just started.");
            await Task.Delay(3000);
            Console.WriteLine("second download has just started.");
    }
}