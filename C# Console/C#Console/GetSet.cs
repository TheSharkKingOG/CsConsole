

public class GetSet
{

    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
}

class Person
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { 
            if(!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
         }
    }
}

