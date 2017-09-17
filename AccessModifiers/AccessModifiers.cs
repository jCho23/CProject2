using System;

////Access Modifiers= A way to control access to a class and / or its members
////Why do we need? To create saftey nets in our program

////Encapsulation = Hide details in Fields or Methods  
//// 1) Define field as private
//// 2) Provide getter/ setter methods as public 

public class Person
{
    private string Name;

    public void SetName(string name)
    {
        if (!String.IsNullOrEmpty(name))
            this.Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}


//Public 

//Private

//Protected

//Internal

//Protected Internal


namespace CProject2.AccessModifiers
{
    public class AccessModifiers
    {
        public AccessModifiers()
        {
        }
    }
}
