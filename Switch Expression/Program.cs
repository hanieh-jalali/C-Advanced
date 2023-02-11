
string name = "EveryThing";

var res = name switch
{
    "Everything" => "Is Nothing",
    "Nothing" => "bela bela bela bela",

    _ => "boro baba"
};
Console.WriteLine(res);