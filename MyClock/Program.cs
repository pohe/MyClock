// See https://aka.ms/new-console-template for more information
using MyClock;

Console.WriteLine("Hello, World!");

Clock c1 = new Clock(22, 59);
c1.AdvanceOneMinute();
Console.WriteLine($"Klokken er {c1.Hours} : { c1.Minutes}  ");
