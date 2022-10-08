// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

await Bootstrapper.Factory.CreateWeb(args).RunAsync();