namespace IoC_Example.Repository;

public class SamsungPayService : IPayService
{
    public string creditType {
        get { return "samsung"; }
    }

    public string Credit()
    {
        return "Samsung";
    }
}