This repo illustrates an issue with System.Reactive.*, [Version 3.1.1](https://www.nuget.org/packages/System.Reactive/3.1.1)

RxTest.Lib contains a single class, that exposes an IObservable<string>

RxTest.Unit contains a single test that tries to access the Observable, getting a runtime exception:

```
Test method RxTest.Unit.UnitTest1.TestMethod1 threw exception: 
System.IO.FileLoadException: Could not load file or assembly 'System.Reactive.Linq, Version=3.0.0.0, Culture=neutral, PublicKeyToken=94bc3704cddfc263' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)

    at RxTest.Lib.Class1.get_TestObservable()
   at RxTest.Unit.UnitTest1.TestMethod1() in C:\Users\joshu\Documents\Visual Studio 2015\Projects\RxTest\RxTest.Unit\UnitTest1.cs:line 14
```