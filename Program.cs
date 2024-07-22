namespace FileHandlingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\roshani.poojari\Desktop\Training\FileHandlingApp\assets\Usernames.txt";
            Console.WriteLine("Enter your username: ");
            string name = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine(name);
            }
        }
    }
}
