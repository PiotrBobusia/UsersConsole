
using UsersConsole.Models;
using UsersConsole.Operations;
using UsersConsole.Services;

Console.WriteLine("Hello, World!");

UsersService usersService = new ();

do
{
    Console.Clear();

    var option = MenuOperations.ShowMenu();

    switch (option)
    {
        case 1:
            Console.WriteLine("Enter first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter date of birth (dd-mm-yyyy):");
            var birthDate = Console.ReadLine();
            try
            {
                usersService.AddUser(firstName, lastName, email, birthDate);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please correct the birth date format (dd-mm-yyyy)");
            }
            break;

        case 2:
            Console.WriteLine("Enter your phrase: ");
            var phrase = Console.ReadLine();
            var findRersult = usersService.FindUser(phrase);
            DisplayOperations.Display(findRersult);
        break;

        case 3:
            var sortResult = usersService.ShowUsersLastNameDesc();
            DisplayOperations.Display(sortResult);
        break;

        case 4:
            var youngestUserResult = usersService.GetYoungestUser();
            DisplayOperations.Display(youngestUserResult);
        break;

        case 5:
            var longestLastNameResult = usersService.GetUserWithLongestLastName();
            DisplayOperations.Display(longestLastNameResult);
        break;

        case 6:
            var reversedFirstNameResult = usersService.GetUsersWithReverseFirstName();
            DisplayOperations.Display(reversedFirstNameResult);
        break;

        case 7:
            return 0;

        _:
            continue;

    }

    Console.WriteLine("\nPRESS [ENTER] TO CONTINUE");
    Console.ReadLine();
} while (true);