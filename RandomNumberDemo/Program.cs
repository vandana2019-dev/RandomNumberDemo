// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random  = new Random();

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(random.Next(10)); // maxvalue is 10
}

Console.WriteLine("random numbers");

for (int i = 0; i < 5; i++)
{
    // inclusive of 5 and less than the max value
    // Console.WriteLine(random.Next(5,10)); // maxvalue is 10
    Console.WriteLine(random.NextDouble() * 2);
}

List<PersonModel> people = new List<PersonModel>
{
    new PersonModel {FirstName ="Tim"},
    new PersonModel{FirstName ="Sue"},
    new PersonModel {FirstName = "Mary"},
    new PersonModel {FirstName ="George"},
    new PersonModel {FirstName = "Jane"},
    new PersonModel {FirstName = "Nancy"},
    new PersonModel {FirstName = "Bob"}
};


Console.WriteLine("** shuffle a shorter list **");

//var sortedPeople = people.OrderBy(x => x.FirstName);
// shuffle a small list
var sortedPeople = people.OrderBy(x => random.Next());

foreach (var p in sortedPeople)
{
    Console.WriteLine(p.FirstName);
}


Console.ReadLine();




public class PersonModel
{
    public string FirstName { get; set; }
}
