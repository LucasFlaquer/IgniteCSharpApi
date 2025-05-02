namespace IgniteCSharpApi.Communications.Requests;

public class UpdatePasswordBody
{
    public string CurrentPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}
