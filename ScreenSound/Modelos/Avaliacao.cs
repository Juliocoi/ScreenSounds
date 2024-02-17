namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        this.Nota = Math.Max(0, Math.Min(10, nota));

    }
    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
