namespace IoC_Example.Repository;

public interface IPayService
{
    string creditType {
        get;
    }
    
    string Credit();
}