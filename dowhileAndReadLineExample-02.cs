string? roleName;
string roleEntered = "";
bool entry = false;

do
{
    Console.WriteLine("Enter your role name (Administor, Manager, or User)");
    roleName = Console.ReadLine();
    if (roleName != null)
    {
        roleEntered = roleName.Trim();
    }

    if (roleEntered.ToLower() == "administrator" || roleEntered.ToLower() == "Manager" || roleEntered.ToLower().ToLower() == "User")
    {
        entry = true;
    }
    else
    {
        Console.WriteLine($"The role name you entered, \"{roleEntered}\" is not valid.");
    }
} while (entry == false);

Console.WriteLine($"Your input value({roleEntered}) has been accepted.");
roleName = Console.ReadLine();
