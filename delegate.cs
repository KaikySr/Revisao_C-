// using System;
// using System.Collections.Generic;
// using System.Linq;

// // Func<int, int, bool> 
// // // entrada, entrada, saida

// // Action<int, int, int> 
// // // entrada, entrada, entrada



// // int duplica(int input) => input * 2;

// // List<int> lista = new List<int> {2,3,4,5};
// // var novaLista = Transforma(lista, duplica);
// // foreach (var i in novaLista)
// // {
// //     Console.WriteLine(1);
// // }

// // List<int> Transforma(List<int> lista, formataInt minhaFuncao)
// // {
// //     var novaLista = new List<int>();

// //     foreach(var i in lista)
// //         novaLista.Add(minhaFuncao(i));

// //     return novaLista;
// // }

// // delegate int formataInt(int input);

// string CaixaAlta(string str) => str.ToUpper();

// string Captalize(string str) => char.ToUpper(str[0]) + str.Substring(1).ToLower();

// string CaptalizeAll(string str)
// {
//     var splited = str.Split(" ");
//     string result = "";

//     foreach (var word in splited)
//     {
//         result += Captalize(word) + " ";
//     }    

//     return result;
// }

// List<string> lista = new List<string> {"kaiky santos", "banana da silVa", "pEdRo"};

// var resultadoCaixaAlta = formataString