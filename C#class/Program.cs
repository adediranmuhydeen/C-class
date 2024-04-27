using C_class;

Student muhydeen = new()
{
    FirstName = "Muhydeen",
    MiddleName = "Adebayo",
    LastName = "Adediran",
    Title = "Eng"
};

Teacher godfada = new()
{
    Id = 1,
    FirstName = "Saheed",
    LastName = "Lawal"

};
godfada.SayMyName();

muhydeen.SayMyName();

Console.WriteLine(muhydeen.MyName(muhydeen.FirstName, muhydeen.LastName));

Console.WriteLine(muhydeen.MyName(muhydeen.FirstName, muhydeen.LastName, muhydeen.MiddleName));

Console.WriteLine(muhydeen.MyName(muhydeen.FirstName, muhydeen.LastName, muhydeen.MiddleName, muhydeen.Title));