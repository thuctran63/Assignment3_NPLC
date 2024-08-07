

using Assignment3.Exercise1;
using Assignment3.Exercise2;

int choice = 0;
while (true)
{
    Console.Clear();
    Console.WriteLine("1. Exercise1");
    Console.WriteLine("2. Exercise2");
    Console.WriteLine("3. Exit");

    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch(choice)
    {
        case 1:
            DepartmentManage.main();
            break;
        case 2:
            Main.main();
            break;
        case 3:
            return;
    }
}