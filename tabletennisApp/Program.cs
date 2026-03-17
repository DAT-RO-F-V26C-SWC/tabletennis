// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;
using tabletennisLib.model;

Console.WriteLine("Hello, World!");

MemberRegister register = new MemberRegister();

Member member1 = new Member(2, "Peter", "55667788", 1999);
Member member2 = new Member(4, "Vibeke", "66554433", 2004);
Member member3 = new Member(6, "Mikkel", "11660022", 2020);
Member member4 = new Member(8, "Anders", "11122233", 1990);
Member member5 = new Member(10, "Jens", "77665588", 2001);

register.AddMember(member1);
register.AddMember(member2);
register.AddMember(member3);
register.AddMember(member4);
register.AddMember(member5);

Console.WriteLine(" Hele listen");
Console.WriteLine(register); // kalder automatisk ToString


Console.WriteLine();
Console.WriteLine("nummer 4: " + register.GetMember(4)  );
Console.WriteLine("nummer 5: " + register.GetMember(5));
Console.WriteLine("phone exists: " + register.GetMember("11660022"));
Console.WriteLine("phone not exists: " + register.GetMember("33333333"));


Console.WriteLine("fjerne nummer 4");
register.RemoveMember(4);
Console.WriteLine("list all");
foreach(Member m in register.ListAll())
{
    Console.WriteLine(m);
}

Console.WriteLine("opdaterer nummer 8 til tlf 66666666");
Member updateMember = new Member(8, "Anders", "66666666", 1990);
register.UpdateMember(8, updateMember);
foreach (Member m in register.ListAll())
{
    Console.WriteLine(m);
}