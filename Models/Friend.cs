#pragma warning disable CS8618 //just disables the warnings of the values being potentially null
namespace FirstMVC.Models;

public class Friend
{
    public string FirstName {get;set;} //adding a ?mark at the end of "string" would allow us to have a null value, like comment
    public string LastName {get;set;} ///example would be public string? LastName {get;set;}
    public string Location {get;set;}
    public int Age {get;set;}

}