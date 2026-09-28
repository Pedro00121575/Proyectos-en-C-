using Spectre.Console;

var fname = AnsiConsole.Ask<string>("Indica tu nombre: ");
var lname = AnsiConsole.Ask<string>("Indica cuál es tu apellido: ");
var altura = AnsiConsole.Ask<float>("Indica cuál es tu altura: ");
var age = AnsiConsole.Ask<int>("Indica cuál es tu edad: ");

AnsiConsole.MarkupLine(
    $"Hola, mi nombre es [blue]{fname} {lname}[/], mi altura es {altura} y mi edad es {age}."
);