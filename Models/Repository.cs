namespace nutrition.Models
{
    public class Repository
    {
        public static List<Food> responses = new();

        public static IEnumerable<Food> Responses => responses;

        public static void AddResponse(Food response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}