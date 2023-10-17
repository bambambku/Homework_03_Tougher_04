
//var months = new Dictionary<string month, int days>();
var months = new (string month, int daysCount)[]
{
    ("January", 31),
    ("February", 28),
    ("March", 31),
    ("April", 30),
    ("May", 31),
    ("June", 30),
    ("July", 31),
    ("August", 31),
    ("September", 30),
    ("October", 31),
    ("November", 30),
    ("December", 31)
};

class Date
{
    int _day;
    int _month;
    int _year;
}