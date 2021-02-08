object o = null;
string s = null;

object x = null;
object y = x ?? 100;  // равно 100, так как x равен null

object z = 200;
object t = z ?? 44; // равно 200, так как z не равен null

int x = 44;
int y = x ?? 100;

class User
{
    public Phone Phone { get; set; }
}

class Phone
{
    public Company Company { get; set; }
}

class Company
{
    public string Name { get; set; }
}

User user = new User();
Console.WriteLine(user.Phone.Company.Name);

User user = new User();

if (user != null)
{
    if (user.Phone != null)
    {
        if (user.Phone.Company != null)
        {
            string companyName = user.Phone.Company.Name;
            Console.WriteLine(companyName);
        }
    }
}

if (user != null && user.Phone != null && user.Phone.Company != null)
{
    string companyName = user.Phone.Company.Name;
    Console.WriteLine(companyName);
}

string companyName = user?.Phone?.Company?.Name;

User user = new User();
string companyName = user?.Phone?.Company?.Name ?? "не установлено";
Console.WriteLine(companyName);