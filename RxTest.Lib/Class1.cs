using System;
using System.Reactive.Subjects;

namespace RxTest.Lib
{
    public class Class1
    {
        public IObservable<string> TestObservable => new Subject<string>();
    }
}
