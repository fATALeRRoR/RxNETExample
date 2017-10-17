using System;

namespace RxNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter on empty line to quit");
            Console.WriteLine("Publisher (observable) started");
            Console.WriteLine("Subscriber (observer) started");

            TestSubject.Instance.Subscribe(a =>
            {
                Console.WriteLine($"Subscriber: {a.Message}");
            }, () =>
            {
                Console.WriteLine("Subscriber is done");
            });

            while (true)
            {
                var s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s))
                {
                    Console.WriteLine("Publisher is done");
                    TestSubject.Instance.OnCompleted();
                    break;
                }

                Console.WriteLine($"Publisher: {s}");
                TestSubject.Instance.OnNext(new DataDto
                {
                    Message = s
                });
            }
        }
    }
}
