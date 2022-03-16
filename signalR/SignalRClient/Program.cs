// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.SignalR.Client;

Console.WriteLine("Hello, World!");

HubConnection conn = new HubConnectionBuilder()
    .WithUrl($"http://192.168.1.128:9071/demohub") //设置服务端地址
    .WithAutomaticReconnect()
    .Build();

conn.On<string, string>("ReceiveMessage", (user, message) => { 
    Console.WriteLine($"{user}:{message}");
});
conn.StartAsync();
conn.InvokeAsync("SendMessage", "Demo", "HelloWorld");