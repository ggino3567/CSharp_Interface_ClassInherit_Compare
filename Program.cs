namespace AnyCS;

/*
1.分開方法的定義與實作：介面抽離方法的定義與實作，你可以將其視為一種完全只有抽象方法的純抽象類別。
2.避免繼承架構的相依性：介面最大的好處在於避免繼承架構關系裏，基礎類別與衍生類別之間緊密的相依性，提供最大的設計彈性。
3.公開所有成員：所有的介面方法成員均只包含方法名稱，且一律為 public 存取層級。
4.實作所有介面成員：繼承介面的衍生類別必須實作所有的介面成員，而且成員的名稱、參數、傳回值型別都必須完全符合，
  你可以實作一個不包含任何內容的方法，避免編譯錯誤，但是無論如何，衍生類別一定要完成所有的介面方法實作。
*/
internal class Program
{
    static void Main(string[] args)
    {
        RCSample cSample = new RCSample(11, "Eleeeeee");
        cSample.Get();

        CLAA cLAA = new CLAA();
        cLAA.A_Method();
        cLAA.B_Method(); //this method is empty, do nothing
    }
}

//interface : 將成員規格與實作分開
interface ISample
{
    int Num { get; set; }
    string Name { get; set; }
    public void Get();
}

//abstract class : 抽象class不能實作只能繼承
public abstract class CSample : ISample
{
    public int Num { get; set; }
    public string Name { get; set; }
    public void Get()
    {
        System.Console.WriteLine($"{Num}, {Name}");
    }

    public CSample(int num, string name)
    {
        this.Num = num;
        this.Name = name;
    }
}

public class RCSample : CSample
{
    public RCSample(int num, string name) : base(num, name) { }
}

interface MethodSample
{
    //A_Method : Print()
    public void A_Method();
    public void B_Method();
}

public class CLAA : MethodSample
{
    public void A_Method()
    {
        System.Console.WriteLine("This is A_Method()");
    }
    public void B_Method() { }
}