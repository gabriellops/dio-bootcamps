namespace Ex02.src.Classes
{
    public class Raca
    {
        public Raca(int Forca, int Destreza, int Constituicao, int Inteligencia, int Sabedoria, int Carisma)
        {
            this.Forca = Forca;
            this.Destreza = Destreza;
            this.Constituicao = Inteligencia;
            this.Sabedoria = Sabedoria;
            this.Carisma = Carisma;       
        }

            public int Forca { get; set; }
            public int Destreza { get; set; }
            public int Constituicao { get; set; }
            public int Inteligencia { get; set; }
            public int Sabedoria { get; set; }
            public int Carisma { get; set; }
    }
}
    