namespace Profile.BL.Infrastructure
{
    public class OperationInfo
    {
        public const bool Failure = false;
        public const bool Success = true;
        public const string SuccessMessage = "Successful operation";

        public OperationInfo(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }

        public static OperationInfo GetSuccessOperation()
        {
            return new OperationInfo(Success, SuccessMessage);
        }
    }
}
