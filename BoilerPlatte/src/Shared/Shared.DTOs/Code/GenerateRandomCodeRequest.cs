namespace BoilerPlatte.Shared.DTOs.Code;

public class GenerateRandomCodeRequest : IMustBeValid
{
    public int NSeed { get; set; }
}
