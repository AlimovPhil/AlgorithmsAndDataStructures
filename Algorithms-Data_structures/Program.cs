using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    public string? FirstName { get; set; }
    public string? SecondName { get; set; }
    public override bool Equals(object obj)
    {
        var user = obj as User;
        if (user == null)
            return false;
        return FirstName == user.FirstName && SecondName == user.SecondName;
    }
    public override int GetHashCode()
    {

        int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;
        int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
        return firtsNameHashCode ^ secondNameHashCode; // ^ (логическое исключающее ИЛИ) Также эту операцию называют XOR (Подразрядные операции)

        //для ленивых (может нарушить работу словаря)
        //return HashCode.Combine(FirstName, SecondName); 

        //другой вариант подсчетa вручную
        //int hash = 397;
        //unchecked
        //{
        //    hash = (hash * 397) ^ FirstName.GetHashCode();
        //    hash = (hash * 397) ^ SecondName.GetHashCode();
        //}
        //return hash;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var hashSet = new HashSet<User>();
        var user = new User() { FirstName = "Barbara", SecondName = "Santa" };
        var user1 = new User() { FirstName = "Gordon", SecondName = "Freeman" };
        hashSet.Add(user);
        hashSet.Add(user1);

        var searchUser = new User()
        {
            FirstName = "Gordon",
            SecondName = "Freeman"
        };
        Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUser)}");
        Console.WriteLine("Завершение работы программы...");
        Console.ReadLine();
    }
}



