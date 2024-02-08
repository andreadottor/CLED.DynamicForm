namespace CLED.DynamicForm.Questions;

class TextQuestion : IQuestion
{
    public int Id { get; set; }
    public string? Text { get; set; }
    public bool IsRequired { get; set; }


    public string Ask()
    {
        Console.WriteLine(Text);
        var answer = Console.ReadLine();
        while (IsRequired && string.IsNullOrEmpty(answer))
        {
            Console.WriteLine("la domanda è obbligatoria. fornire l'informazione");
            answer = Console.ReadLine();
        }

        return answer ?? string.Empty;

    }
}
