namespace PetShopScheduling.Argument.Internal.ApiResponse;

public class ApiResponse<TResponse>
{
    #region Properties
    public bool IsSuccess { get; private set; } = true;
    public List<string> ErrorMessageList { get; private set; } = [];
    public TResponse? Response { get; private set; }
    #endregion

    public void SetError(string errorMessage)
    {
        IsSuccess = false;
        ErrorMessageList.Add(errorMessage);
    }
}
