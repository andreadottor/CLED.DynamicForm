namespace CLED.DynamicForm.Questions;

class NumericQuestion : IQuestion
{
    public int Id { get; set; }

    public string? Text { get; set; }
    public bool IsRequired { get; set; }

    public string Ask()
    {
        Console.WriteLine(Text);
        var answer = Console.ReadLine();

        while ((IsRequired && string.IsNullOrEmpty(answer)) 
                || !int.TryParse(answer, out _))
        {
            Console.WriteLine("Rinserire l'input o Dato obbligatorio");
            answer = Console.ReadLine();
        }

        return answer ?? string.Empty;

    }
}
