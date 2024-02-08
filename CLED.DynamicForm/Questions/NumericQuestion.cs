

namespace CLED.DynamicForm.Questions
{
    class NumericQuestion : IQuestion
    {
        public int Id { get; set; }

        public string? Text { get; set; }
        public bool IsRequired { get; set; }

        public string Ask()
        {
            Console.WriteLine(Text);
            var answer = Console.ReadLine();
            var isNumber = int.TryParse(answer, out int number);

            while ((IsRequired && string.IsNullOrEmpty(answer)) || !isNumber)
            {
                Console.WriteLine("Rinserire l'input o Dato obbligatorio");
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out number);
            }

            return answer ?? string.Empty;

        }
    }
}
