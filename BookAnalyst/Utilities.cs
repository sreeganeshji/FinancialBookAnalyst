class Utilities
{
    public T Deserialize<T>(string jsonBody)
    {
        try
        {
            return System.Text.Json.JsonSerializer.Deserialize<T>(jsonBody);
        }
        catch(Exception e)
        {
            Console.WriteLine($"Could not deserialize: {e}");
            throw;
        }
    }
}