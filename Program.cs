using _240318_1.Models;


Customer c1 = new Customer();

c1.CustomerId = 1;
c1.FirstName = "Alexandre";
c1.LastName = "Ribeiro";
c1.BirthDate = new DateTime();
c1.EmailAddress = "alexandrejoseribeiro6@gmail.com";

Console.WriteLine( $"Nome: {c1.FirstName} {c1.LastName}\nEmail: {c1.EmailAddress}");

Console.WriteLine();