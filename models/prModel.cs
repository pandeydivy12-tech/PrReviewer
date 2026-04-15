namespace RelinkMCP.models;

public class PRDiff
{
    public bool TransactionSuccess{get;set;}
    public string TransactionMessage = new ("");

    public PRDiff SetTransactionStatus(string msg, bool IsSuccess)
    {
        TransactionMessage = msg;
        TransactionSuccess = IsSuccess;
        return this;
    }
}