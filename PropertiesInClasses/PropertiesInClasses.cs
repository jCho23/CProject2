using System;

////Properties= A class member that encapsulates a getter/setter for accessing a field
//// Why do we need Properties? = To create a getter/setter with less code
 
////Fields Example
public class Person
{
    private DateTime _birthdate;

    public void SetBirthdate(DateTime birthdate)
    {
        this._birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}

////Properties Example

namespace CProject2
{
    public class PropertiesInClasses
    {
        public PropertiesInClasses()
        {
        }
    }
}
