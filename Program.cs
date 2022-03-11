using dataproggassg2;

Console.WriteLine("Press 1 to sign up\n" +
    "Press 2 to Login\n" +
    "Press 3 to view details");
Console.WriteLine("Enter your option");

int option = int.Parse(Console.ReadLine());
if(option == 1)
{
    Json.Start(@"C:\Users\Kiran\Desktop\New folder\student.json");
}
        
else if(option == 2)
{
    Login lg = new Login();
    lg.login();

}
else if(option == 3)
{
    Console.WriteLine("Enter admin password");
    string pass=Console.ReadLine();
    string passwordIsValid = pass = "admin123";
    bool result = false;
    if (pass == "admin123")
    {
        result = true;
        viewdetails vd = new viewdetails();
        vd.read();

    }
    else
    {
        result = false;
        Console.WriteLine("Enter valid password");
    }
    

}
else
{
    Console.WriteLine("enter a valid choice");
}
        
    
        









