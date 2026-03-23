using Microsoft.Win32;
using tabletennisLib.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

bool TestData = true;
List<Member> members = new List<Member>();
if (TestData)
{
    Member member1 = new Member(2, "Peter", "55667788", 1999);
    Member member2 = new Member(4, "Vibeke", "66554433", 2004);
    Member member3 = new Member(6, "Mikkel", "11660022", 2020);
    Member member4 = new Member(8, "Anders", "11122233", 1990);
    Member member5 = new Member(10, "Jens", "77665588", 2001);

    members.Add(member1);
    members.Add(member2);
    members.Add(member3);
    members.Add(member4);
    members.Add(member5);
}

builder.Services.AddSingleton<MemberRegister>(new MemberRegister(members));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
