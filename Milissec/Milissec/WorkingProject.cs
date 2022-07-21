DateTime DataAtual = new DateTime(2022, 12, 31, 23, 59, 59, 999);


var MsAtual = DataAtual.Millisecond;
int cent = MsAtual / 100;
int dez = (MsAtual - cent * 100) / 10;
int uni = (MsAtual - cent * 100) - dez * 10;
DateTime DataArredondada;


Console.WriteLine("Data inicial = " + DataAtual);
Console.WriteLine(DataAtual.Millisecond);

switch (uni)
{
    case 1:
        DataArredondada = DataAtual.AddMilliseconds(-1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 2:
        DataArredondada = DataAtual.AddMilliseconds(1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 4:
        DataArredondada = DataAtual.AddMilliseconds(-1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 5:
        DataArredondada = DataAtual.AddMilliseconds(2);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 6:
        DataArredondada = DataAtual.AddMilliseconds(1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 8:
        DataArredondada = DataAtual.AddMilliseconds(-1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    case 9:
        DataArredondada = DataAtual.AddMilliseconds(1);
        Console.WriteLine("Data Arredondada = " + DataArredondada.Millisecond);
        DataAtual = DataArredondada;
        break;
    default:
        break;
}

Console.WriteLine("Data final = " + DataAtual);
Console.WriteLine(DataAtual.Millisecond);