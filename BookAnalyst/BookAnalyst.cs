using System;
using System.Net.Http;
using System.Threading.Tasks;

public enum Statement
{
    INCOME_STATEMENT, BALANCE_SHEET, CASH_FLOW, OVERVIEW
}

public enum Company
{
    MSFT, AMZN, GOOG, AAPL
}
class BookAnalyst
{
    static readonly HttpClient client = new HttpClient();

    private const string _baseUrl = "https://www.alphavantage.co/query";

    private const string _apiKey = "H6NRAF8GZVQWKQSY"; // Replace with your Alpha Vantage API key


    public async Task<Sheet> TryGetStatement<Sheet>(Company company)
    {
        Statement statement = Statement.BALANCE_SHEET;
        try
        {
            if(typeof(Sheet) == typeof(BalanceSheet))
            {
                statement = Statement.BALANCE_SHEET;
            }
            else if (typeof(Sheet) == typeof(IncomeStatement))
            {
                statement = Statement.INCOME_STATEMENT;
            }
            else if (typeof(Sheet) == typeof(CashFlow))
            {
                statement = Statement.CASH_FLOW;
            }

            statement = Statement.OVERVIEW;

            string url = $"{_baseUrl}?function={statement}&symbol={company}&apikey={_apiKey}";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            Utilities utilities = new Utilities();
            return utilities.Deserialize<Sheet> (responseBody);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            throw;
        }
    }
}