using System;
using Milissec;

class WorkingProject
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------Primeira Data------------------------");
        var Data1 = new DateConverter(new DateTime(2022, 12, 31, 23, 59, 59, 997));
        Console.WriteLine("Data obtida: " + Data1.DataAtual);
        Console.WriteLine("Milissegundos: " + Data1.DataAtual.Millisecond);
        Data1.ArredondaData();
        Console.WriteLine("Data Arredondada: " + Data1.DataAtual);
        Console.WriteLine("Milissegundos: " + Data1.DataAtual.Millisecond);

        Console.WriteLine("----------------Segunda Data------------------------");
        var Data2 = new DateConverter(new DateTime(2022, 12, 31, 23, 59, 59, 542));
        Console.WriteLine("Data obtida: " + Data2.DataAtual);
        Console.WriteLine("Milissegundos: " + Data2.DataAtual.Millisecond);
        Data2.ArredondaData();
        Console.WriteLine("Data Arredondada: " + Data2.DataAtual);
        Console.WriteLine("Milissegundos: " + Data2.DataAtual.Millisecond);

        Console.WriteLine("----------------Terceira Data------------------------");
        var Data3 = new DateConverter(new DateTime(2022, 12, 31, 23, 24, 59, 998));
        Console.WriteLine("Data obtida: " + Data3.DataAtual);
        Console.WriteLine("Milissegundos: " + Data3.DataAtual.Millisecond);
        Data3.ArredondaData();
        Console.WriteLine("Data Arredondada: " + Data3.DataAtual);
        Console.WriteLine("Milissegundos: " + Data3.DataAtual.Millisecond);

        Console.WriteLine("----------------Quarta Data------------------------");
        var Data4 = new DateConverter(new DateTime(2022, 12, 31, 23, 59, 59, 991));
        Console.WriteLine("Data obtida: " + Data4.DataAtual);
        Console.WriteLine("Milissegundos: " + Data4.DataAtual.Millisecond);
        Data4.ArredondaData();
        Console.WriteLine("Data Arredondada: " + Data4.DataAtual);
        Console.WriteLine("Milissegundos: " + Data4.DataAtual.Millisecond);

        Console.WriteLine("----------------Quinta Data------------------------");
        var Data5 = new DateConverter(new DateTime(2022, 12, 31, 23, 59, 59, 999));
        Console.WriteLine("Data obtida: " + Data5.DataAtual);
        Console.WriteLine("Milissegundos: " + Data5.DataAtual.Millisecond);
        Data5.ArredondaData();
        Console.WriteLine("Data Arredondada: " + Data5.DataAtual);
        Console.WriteLine("Milissegundos: " + Data5.DataAtual.Millisecond);

    }
}