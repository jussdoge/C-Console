
class GetSet
{
    private string _model

    //public string _model
    {
        get { return _model; }
        set {}
    }

}

class Person
{

    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
        }
    }
}

class Short
{
    public string Cut { get; set; }
}
class BankAccount{
    private decimal _balance

    //public decimal _balance
    {
        get{ return _balance; }
        set{
            if(value >= 0)
            {
                _balance = value;
            }
    }
    }
}