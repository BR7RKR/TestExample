namespace TestExample;

public class SomeService
{
    private string veryImportantVar = "1233";
    
    public void ChangeVeryImportantVar(string someExplicitVar)
    {
        veryImportantVar = someExplicitVar;
    }

    public string ShowVeryImportantVar()
    {
        return veryImportantVar;
    }
}