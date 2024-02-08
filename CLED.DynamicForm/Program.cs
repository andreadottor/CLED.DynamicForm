
using CLED.DynamicForm.Questions;

var questions = new List<IQuestion>();
var answers = new Dictionary<int, string>();
// TODO: creo le domande da porre
var nameQuestion = new TextQuestion();
nameQuestion.Id = 1;
nameQuestion.Text = "inserire il nome";
nameQuestion.IsRequired = true;
questions.Add(nameQuestion);

var emailQuestion = new TextQuestion();
emailQuestion.Id = 2;
emailQuestion.Text = "inserire l'email";
questions.Add(emailQuestion);

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