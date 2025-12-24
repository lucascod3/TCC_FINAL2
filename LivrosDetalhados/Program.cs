using System;
using System.Collections.Generic;

class Livro
{
    public int Numero { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
    public string Descricao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Lista simulada de livros
        List<Livro> livros = new List<Livro>
        {
            new Livro { Numero = 1, Titulo = "Algoritmos e Estruturas de Dados", Autor = "N. Wirth", Ano = 1976, Descricao = "Clássico sobre fundamentos da programação." },
            new Livro { Numero = 2, Titulo = "Clean Code", Autor = "Robert C. Martin", Ano = 2008, Descricao = "Práticas para escrever código limpo e sustentável." },
            new Livro { Numero = 3, Titulo = "Design Patterns", Autor = "Erich Gamma et al.", Ano = 1994, Descricao = "Catálogo de padrões de projeto orientados a objetos." },
            new Livro { Numero = 4, Titulo = "Inteligência Artificial: Uma Abordagem Moderna", Autor = "Russell & Norvig", Ano = 2010, Descricao = "Livro referência em IA." },
            new Livro { Numero = 5, Titulo = "Introdução à Programação em C#", Autor = "John Sharp", Ano = 2015, Descricao = "Guia prático para aprender C#." }
            
        };

        // Ordenar alfabeticamente pelo título
        livros.Sort((x, y) => x.Titulo.CompareTo(y.Titulo));

        Console.WriteLine("=== Lista de Livros ===");
        foreach (var livro in livros)
        {
            Console.WriteLine($"{livro.Numero} - {livro.Titulo}");
        }

        Console.WriteLine("\nDigite o número do livro para ver detalhes:");
        int escolha = Convert.ToInt32(Console.ReadLine());

        Livro selecionado = livros.Find(l => l.Numero == escolha);

        if (selecionado != null)
        {
            Console.WriteLine($"\nTítulo: {selecionado.Titulo}");
            Console.WriteLine($"Autor: {selecionado.Autor}");
            Console.WriteLine($"Ano: {selecionado.Ano}");
            Console.WriteLine($"Descrição: {selecionado.Descricao}");
        }
        else
        {
            Console.WriteLine("Número inválido. Tente novamente.");
        }
    }
}