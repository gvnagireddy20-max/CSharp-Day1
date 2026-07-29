string [ ] names = new string[5];
for (int i =0; i<names.Length; i++)
{
    Console.WriteLine($"Enter name {i+1}: ");
    names[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Nmaes In Reverse Order: ");

for (int i = names.Length - 1; i >= 0; i --)

{
    Console.WriteLine(names[i].ToUpper());
}