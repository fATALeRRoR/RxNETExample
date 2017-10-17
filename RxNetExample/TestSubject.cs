using System;
using System.Diagnostics;
using System.Reactive.Subjects;

namespace RxNetExample
{
    public static class TestSubject
    {
        static TestSubject()
        {
            //It is thread safe, right?
            Instance = new Subject<DataDto>();
        }

        public static ISubject<DataDto> Instance { get; }
    }
}
