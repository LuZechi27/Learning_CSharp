using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class FuncoesTexto
    {
        static void Main(string[] args)
        {
            WriteLine("------ Funções de Textos ------");
            string empresa = " Microsoft Corporation  ";

            WriteLine("TRIM - retira os espaços em branco antes e após a expressão");
            WriteLine($"Nome sem espaços: {empresa.Trim()}\n");

            WriteLine("Length - retorna a qtde de caracteres");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            empresa = empresa.Trim();
            WriteLine($"Tamanho da empresa após o TRIM(): {empresa.Length}\n");

            WriteLine("ToUpper - converte todos os caracteres para maiúsculo");
            WriteLine($"Maiúsculo: {empresa.ToUpper()}\n");

            WriteLine($"Minúsculo: {empresa.ToLower()}\n\n");

            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";

            //comp1
            if (nomeUpper == nomeLower)
                WriteLine("1 - Iguais");
            else
                WriteLine("1 - Diferentes");

            //comp2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - Iguais");
            else
                WriteLine("2 - Diferentes");

            //comp3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - Iguais");
            else
                WriteLine("3 - Diferentes");

            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"Texto esquerdo: {empresa.Remove(9)}");

            WriteLine("Captura o primeiro nome");
            string[] nomes = { "Fabricio dos Santos", "José da Silva", "Roberta Brasil" };

            foreach (var n in nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(' '))}");
            }

            //Replace
            WriteLine($"Texto atual: {empresa}");
            var novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"texto trocado: {novaEmpresa}");

            string NivelLivro = "Este livro é básico de C#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;
            foreach (var exp in blocos)
            {
                WriteLine($"texto {contador++}: {exp}");
            }
            WriteLine($"Qtde de palavras: {blocos.Count()}");

            //Substring(x, y) == string[x, y] (python)
            string[] cesta = { "5 Laranjas", "10 GOiabas vermelhas", "5 Pêssegos doces", "5 Bananas" };
            int qtde = 0;
            foreach (var p in cesta)
            {
                qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(' ')));
            }
            WriteLine($"Quantidade total: {qtde}");

            int dia = 28;
            int mes = 06;
            int ano = 2025;

            DateTime dtAniversario = new DateTime(ano, mes, dia);
            DateTime dtFesta = new DateTime(2025, 08, 24);

            WriteLine("=========Funções de data==========");

            WriteLine($"Aniversário: {dtAniversario}");
            WriteLine($"Aniversário: {dtAniversario:dd/MM/yyyy}");
            WriteLine($"Aniversario: {dtAniversario:dddd/MMM/yyyy}");
            WriteLine($"Aniversário: {dtAniversario:dddd dd/MMMM/yyyy}");
        }
    }
}