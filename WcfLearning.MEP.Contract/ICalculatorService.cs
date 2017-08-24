using System.ServiceModel;

namespace WcfLearning.MEP.Contract
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        double Divide(int a, int b);
    }
}
