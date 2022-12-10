public class CheckboxData
{
    public String item { get; set; } = "";
    public bool isClicked { get; set; } = false;
    public CheckboxData(String i, bool c)
    {
        item = i;
        isClicked = c;
    }
}