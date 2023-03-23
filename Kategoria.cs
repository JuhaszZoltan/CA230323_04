namespace CA230323_04
{
    internal class Kategoria
    {
        public string Nev { get; set; }
        public int Tulelok { get; set; }
        public int Eltuntek { get; set; }
        public int UtasokSzama => Tulelok + Eltuntek;

        public Kategoria(string sor)
        {
            string[] v = sor.Split(';');
            Nev = v[0];
            Tulelok = int.Parse(v[1]);
            Eltuntek = int.Parse(v[2]);
        }
    }
}
