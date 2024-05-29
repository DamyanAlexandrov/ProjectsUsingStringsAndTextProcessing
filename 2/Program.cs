string[] input = Console.ReadLine().Split('\\').Last().Split('.');
Console.WriteLine($"File name: {input[0]}");
Console.WriteLine($"File extension: {input[1]}");
