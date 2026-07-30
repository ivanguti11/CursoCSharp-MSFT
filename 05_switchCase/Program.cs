// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
using System.Threading.Tasks.Dataflow;

string sku = "03-BL-S";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
        type = "Sweat shirt";
    break;
    case "02":
    type = "T-Shirt";
    break;
    case "03":
    type = "Sweat pants";
    break;
    default:
        type = "Other";
    break;
}
switch(product[1])
{
    case "BL":
    color = "Negro";
    break;
    case "MN":
    color = "Marron";
    break;
    default:
    color = "Blanco";
    break;
}
switch(product[2])
{
    case "S":
    size = "Chico";
    break;
    case "M":
    size = "Mediana";
    break;
    case "L":
    size = "Largo";
    break;
    default:
    size = "one size fit all";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
