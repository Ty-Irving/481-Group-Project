namespace CookingInstructor;

public interface IClipboardService
{
    Task CopyToClipboard(string text);
}