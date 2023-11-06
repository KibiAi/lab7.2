using lab7._2;

class Program
{
    static void Main()
    {
        Repository<string> stringRepository = new Repository<string>();

        stringRepository.Add("Dog");
        stringRepository.Add("Snake");
        stringRepository.Add("Cat");
        stringRepository.Add("Crocodile");

        Repository<string>.Criteria<string> criteria = s => s.Length > 3;

        List<string> longWords = stringRepository.Find(criteria);

        foreach (string word in longWords)
        {
            Console.WriteLine(word);
        }
    }
}