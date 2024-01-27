using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        BookAnalyst bookAnalyst = new BookAnalyst();

        BalanceSheet financialStatement = await bookAnalyst.TryGetStatement<BalanceSheet>(Company.AAPL);

        Console.WriteLine(financialStatement.Symbol);
    }
}
