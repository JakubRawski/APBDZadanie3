namespace Zadanie3;
[Serializable]
public class OverfillException : Exception
{
    public OverfillException() : base() { }
    public OverfillException(String e) : base(e) { }
}