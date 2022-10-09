using System;
using Example_Factory_Method.Document;

namespace Example_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Document.Document[] documents = new Document.Document[2];
            //
            // documents[0] = new Report();
            // documents[1] = new Resume();
            //
            // foreach (var document in documents)
            // {
            //     Console.WriteLine($"{document.GetType().Name}");
            //     foreach (var page in document.Pages)
            //     {
            //         Console.WriteLine(page.GetType().Name);
            //     }
            // }

            var report = new Resume();
            foreach (var page in report.Pages)
            {
                Console.WriteLine(page.GetType().Name);
            }
        }
    }
}