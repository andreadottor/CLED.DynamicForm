
using CLED.DynamicForm.Questions;

var questions = new List<IQuestion>();
var answers = new Dictionary<int, string>();
// TODO: creo le domande da porre


// TODO: erogo il sondaggio
Console.WriteLine("START");
foreach (var q in questions)
{
    var response = q.Ask();
    answers.Add(q.Id, response);
}

Console.WriteLine("END");
foreach (var a in answers)
    Console.WriteLine($"{a.Key}: {a.Value}");

Console.ReadLine();