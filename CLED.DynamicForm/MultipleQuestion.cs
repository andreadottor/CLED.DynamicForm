using CLED.DynamicForm.Questions;
using Spectre.Console;

namespace CLED.DynamicForm;

class MultipleQuestion : IQuestion
{
    public int Id { get; set; }
    
    public string? Text { get; set; }
    public bool IsRequired { get; set; }

    public List<string> Answers { get; set; }

    public MultipleQuestion()
    {
        Answers = new List<string>();
    }
    
    public string Ask()
    {
        if(!IsRequired)
            Answers.Add(String.Empty);
        var answer = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title(Text)
                .AddChoices(Answers));
        return answer;
    }
}