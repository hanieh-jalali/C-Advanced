
string name = "Hanieh";

var res = name switch
{
    "Hanieh" => "kheili zibast",
    "Babak" => "kheili khare",

    _ => "boro baba"
};
Console.WriteLine(res);