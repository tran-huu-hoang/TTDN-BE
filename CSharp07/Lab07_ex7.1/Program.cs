internal class Program
{
    private static void Main(string[] args)
    {
        DongVat.AnCo.Bo bo = new DongVat.AnCo.Bo("s1", "bo", "100kg");
        DongVat.AnCo.Trau trau = new DongVat.AnCo.Trau("s2", "trau", "100kg");
        DongVat.AnCo.De de = new DongVat.AnCo.De("s3", "de", "100kg");

        DongVat.AnThit.CaSau casau = new DongVat.AnThit.CaSau("s1", "casau", "100kg");
        DongVat.AnThit.Ho ho = new DongVat.AnThit.Ho("s2", "ho", "100kg");
        DongVat.AnThit.SuTu sutu = new DongVat.AnThit.SuTu("s3", "sutu", "100kg");

        //in
        Console.WriteLine("Thong tin dong vat an co: ");
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", bo.Id, bo.Name, bo.Weight);
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", trau.Id, trau.Name, trau.Weight);
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", de.Id, de.Name, de.Weight);

        Console.WriteLine("Thong tin dong vat an thit: ");
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", casau.Id, casau.Name, casau.Weight);
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", ho.Id, ho.Name, ho.Weight);
        Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}", sutu.Id, sutu.Name, sutu.Weight);
    }
}