namespace Backend.C1.EndPoints;
public static class Reverse
{
    public static void ConfigureReverseEP(this WebApplication app)
    {
        app.MapGet("/reverse/{word}", (string word) =>
        {
            var drow = word.Reverse();
            var word2 = string.Concat(drow);

            return new { result = word2, palindrome = word2 == word };
        });
    }
}