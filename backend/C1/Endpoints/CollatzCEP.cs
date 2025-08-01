namespace Backend.C1.EndPoints;

public static class Collatz
{
    public static void ConfigureCollatzCEP(this WebApplication app)
    {
        app.MapGet("/collatz", (int current, int step) =>
        {
            for (int i = 0; i < step; i++)
            {
                if (current % 2 == 0)
                    current /= 2;
                else current = 3 * current + 1;
            }
        });
    }
}