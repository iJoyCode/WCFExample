using System.ServiceModel;

namespace WCFExample
{
    [ServiceContract(Namespace = "TestNamespace")]
    public interface IEightBall
    {
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}