using System;

// Classe principal que representa um Celular
public class Celular
{
    // Propriedades
    public Bateria Bateria { get; private set; }
    public Tela Tela { get; private set; }

    // Construtor
    public Celular()
    {
        Bateria = new Bateria();
        Tela = new Tela();
    }

    // Método para ligar o celular
    public void Ligar()
    {
        Console.WriteLine("Celular ligado.");
    }

    // Método para desligar o celular
    public void Desligar()
    {
        Console.WriteLine("Celular desligado.");
    }
}

// Classe que representa a Bateria
public class Bateria
{
    // Propriedade
    public int NivelCarga { get; private set; }

    // Construtor
    public Bateria()
    {
        NivelCarga = 100; // Inicia com carga total
    }

    // Método para verificar o nível de carga da bateria
    public void VerificarCarga()
    {
        Console.WriteLine($"Nível de carga da bateria: {NivelCarga}%");
    }
}

// Classe que representa a Tela
public class Tela
{
    // Método para exibir uma mensagem na tela
    public void ExibirMensagem(string mensagem)
    {
        Console.WriteLine($"Tela: {mensagem}");
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        // Criar um celular
        Celular meuCelular = new Celular();

        // Ligar o celular
        meuCelular.Ligar();

        // Exibir nível de carga da bateria
        meuCelular.Bateria.VerificarCarga();

        // Exibir mensagem na tela
        meuCelular.Tela.ExibirMensagem("Olá, mundo!");

        // Desligar o celular
        meuCelular.Desligar();
    }
}
