int i;
int iTwo = 170;

string s;
string sTwo = "blue";

bool b;
bool bTwo = true;

float f;
float fTwo = 25f;

double d;
double dTwo = 32.00d;

decimal de;
decimal deTwo = 42.0m;

ulong u;
ulong uTwo = 1900;

Console.WriteLine(iTwo);
Console.WriteLine(dTwo);
Console.WriteLine(deTwo);
Console.WriteLine(uTwo);

string primary = "Dark";
string secondary = "Ghost";

string typing = primary + "/" + secondary;
Console.WriteLine(typing);
Console.WriteLine($"{typing} {iTwo}");

int year = 1832;
string st;
st = Convert.ToString(year);
Console.WriteLine(st);

string yearString = "1932";
int.Parse(yearString);
Console.WriteLine(int.Parse(yearString));
// int yearNumber = 
// Console.WriteLine(yearNumber);
