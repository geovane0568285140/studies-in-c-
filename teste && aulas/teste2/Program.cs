
class Teste
{
    static void Main()
    {

        Func<int, int, int> teste = delegate (int xx, int yy) { return xx + yy; };
        Func<string, string, bool> teste1 = (e, b) => e.Equals(b, StringComparison.OrdinalIgnoreCase);;
        Console.WriteLine("teste " + teste);
        Console.WriteLine(teste1("be", "BE"));
    }
}