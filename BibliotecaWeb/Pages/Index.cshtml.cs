using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BibliotecaWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaWeb.Pages
{
    public class IndexModel : PageModel
    {
        public List<Livro> Livros { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Busca { get; set; }

        public void OnGet()
        {
            var lista = new List<Livro>
            {
                new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "N. Wirth", Ano = 1976, Descricao = "Fundamentos da programação.", CapaUrl = "/images/algoritmos_e_estruturas_de_dados.jpg" },
                new Livro { Titulo = "Artificial Intelligence: Foundations of Computational Agents", Autor = "David Poole & Alan Mackworth", Ano = 2023, Descricao = "Fundamentos de agentes inteligentes.", CapaUrl = "/images/artificial_intelligence.jpg" },
                new Livro { Titulo = "Clean Code", Autor = "Robert C. Martin", Ano = 2008, Descricao = "Código limpo e sustentável.", CapaUrl = "/images/clean-code.jpg" },
                new Livro { Titulo = "Code Complete: A Practical Handbook of Software Construction", Autor = "Steve McConnell", Ano = 2004, Descricao = "Guia abrangente de desenvolvimento de software.", CapaUrl = "/images/code_complete.jpg" },
                new Livro { Titulo = "Computer Networks", Autor = "Andrew S. Tanenbaum", Ano = 2010, Descricao = "Referência em redes de computadores.", CapaUrl = "/images/computer_networks.png" },
                new Livro { Titulo = "Deep Learning", Autor = "Ian Goodfellow, Yoshua Bengio & Aaron Courville", Ano = 2016, Descricao = "Referência em redes neurais profundas.", CapaUrl = "/images/deep_learning.jpg" },
                new Livro { Titulo = "Design Patterns", Autor = "Erich Gamma et al.", Ano = 1994, Descricao = "Padrões de projeto.", CapaUrl = "/images/design_patterns.jpg" },
                new Livro { Titulo = "Sistemas Distribuídos: princípios e paradigmas", Autor = "Andrew S. Tanenbaum & Maarten Van Steen", Ano = 2007, Descricao = "Fundamentos de sistemas distribuídos.", CapaUrl = "/images/distributed_systems.jpg" },
                new Livro { Titulo = "Effective Java", Autor = "Joshua Bloch", Ano = 2018, Descricao = "Boas práticas para desenvolvimento em Java.", CapaUrl = "/images/effective_java.jpg" },
                new Livro { Titulo = "Head First Design Patterns", Autor = "Eric Freeman & Elisabeth Robson", Ano = 2004, Descricao = "Aprendendo padrões de projeto de forma prática.", CapaUrl = "/images/head_first_design_patterns.jpg" },
                new Livro { Titulo = "Inteligência Artificial: Uma Abordagem Moderna", Autor = "Russell & Norvig", Ano = 2010, Descricao = "Livro referência em IA.", CapaUrl = "/images/Inteligência_Artificial_Uma_Abordagem_Moderna.jpg" },
                new Livro { Titulo = "Introduction to Algorithms", Autor = "Cormen, Leiserson, Rivest & Stein", Ano = 2009, Descricao = "Referência clássica em algoritmos.", CapaUrl = "/images/introduction_to_algorithms.jpg" },
                new Livro { Titulo = "Learning SQL: Generate, Manipulate, and Retrieve Data", Autor = "Alan Beaulieu", Ano = 2020, Descricao = "Guia para aprender SQL.", CapaUrl = "/images/learning_sql.jpg" },
                new Livro { Titulo = "Microsoft Visual C# Step by Step (Eighth Edition)", Autor = "John Sharp", Ano = 2015, Descricao = "Guia prático para aprender C#.", CapaUrl = "/images/Microsoft_Visual.jpg"},
                new Livro { Titulo = "Programming Pearls", Autor = "Jon Bentley", Ano = 1999, Descricao = "Soluções criativas para problemas de programação.", CapaUrl = "/images/programming_pearls.jpg" },
                new Livro { Titulo = "Python Crash Course", Autor = "Eric Matthes", Ano = 2019, Descricao = "Introdução prática ao Python.", CapaUrl = "/images/python_crash_course.jpg" },
                new Livro { Titulo = "Refactoring: Improving the Design of Existing Code (2nd Edition)", Autor = "Martin Fowler", Ano = 2018, Descricao = "Melhoria contínua do código.", CapaUrl = "/images/refactoring.jpg" },
                new Livro { Titulo = "Structure and Interpretation of Computer Programs", Autor = "Harold Abelson & Gerald Jay Sussman", Ano = 1996, Descricao = "Fundamentos da ciência da computação.", CapaUrl = "/images/sicp.jpg" },
                new Livro { Titulo = "The Pragmatic Programmer", Autor = "Andrew Hunt & David Thomas", Ano = 1999, Descricao = "Boas práticas para programadores.", CapaUrl = "/images/pragmatic_programmer.jpg" },
                new Livro { Titulo = "You Don’t Know JS", Autor = "Kyle Simpson", Ano = 2020, Descricao = "Série sobre JavaScript moderno.", CapaUrl = "/images/you_dont_know_js.jpg" },
            };

            // Ordena alfabeticamente e reatribui os números
            lista = lista.OrderBy(l => l.Titulo).ToList();
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Numero = i + 1;
            }

            // Se o usuário digitou algo, filtra
            if (!string.IsNullOrEmpty(Busca))
            {
                Livros = lista
                    .Where(l =>
                        l.Titulo.Contains(Busca, System.StringComparison.OrdinalIgnoreCase) ||
                        l.Numero.ToString() == Busca)
                    .OrderBy(l => l.Titulo)
                    .ToList();
            }
            else
            {
                Livros = lista;
            }
        }
    }
}