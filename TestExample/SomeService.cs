namespace TestExample;

public class SomeService
{
    private string veryImportantVar = "default";
    
    public void ChangeVeryImportantVar(string someExplicitVar)
    {
        veryImportantVar = someExplicitVar;
    }

    public string ShowVeryImportantVar()
    {
        return veryImportantVar;
    }
}