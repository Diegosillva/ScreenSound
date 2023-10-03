using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasResgistradas)
    {
        Console.WriteLine("Tchau Tchau: ");
    }
}
