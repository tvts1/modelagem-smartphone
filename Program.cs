using System;
using phone.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias dos smartphones
        Smartphone myNokia = new Nokia(number: "123-456-7890", model: "Nokia 3310", imei: "111222333444555", memory: 512);
        Smartphone myIphone = new Iphone(number: "987-654-3210", model: "iPhone 14", imei: "555444333222111", memory: 4096);

        // Fazendo chamadas
        myNokia.MakeCall();
        myIphone.ReceiveCall();

        // Instalando aplicativos
        myNokia.InstallApp("Snake");
        myIphone.InstallApp("WhatsApp");

        Console.WriteLine("\nSmartphone details:");
        PrintSmartphoneInfo(myNokia);
        PrintSmartphoneInfo(myIphone);
    }

    static void PrintSmartphoneInfo(Smartphone phone)
    {
        Console.WriteLine($"Model: {phone.Model}");
        Console.WriteLine($"IMEI: {phone.IMEI}");
        Console.WriteLine($"Number: {phone.Number}");
        Console.WriteLine($"Memory: {phone.Memory} MB\n");
    }
}
