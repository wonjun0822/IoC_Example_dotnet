namespace IoC_Example.Repository;

public class NaverPayService : IPayService
{
    public string creditType {
        get { return "naver"; }
    }

    public string Credit()
    {
        return "Naver";
    }
}