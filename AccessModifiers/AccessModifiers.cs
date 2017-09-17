using System;

////Access Modifiers= A way to control access to a class and / or its members
////Why do we need? To create saftey nets in our program

////Encapsulation = Hide details in Fields or Methods  
//// 1) Define field as private
//// 2) Provide getter/ setter methods as public 
//// 
////*Classes and Methods= PascalCase
/// *Fields= camelCase prefixed with an underline 
public class Person
{
    //Notice that the fields are represented by _name
    private string _name;

    //Here, with a Setter and Getter, we can introduce Logic into our fields
    public void SetName(string name)
    {
        if (!String.IsNullOrEmpty(name))
            this._name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

////5 types of Access Modifiers
//Public 
//Private
//Protected
//Internal
//Protected Internal


