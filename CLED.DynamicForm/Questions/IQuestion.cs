namespace CLED.DynamicForm.Questions;

interface IQuestion
{
    int Id { get; }

    string Ask();
}
