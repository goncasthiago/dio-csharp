using System.Text;
using static System.Console;

var sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("Caracteres na segunda linha para ler");
sb.AppendLine("Finalmente, o final");

using var sr = new StringReader(sb.ToString());

//var texto = sr.ReadToEnd(); // Lê tudo de uma vez

var buffer = new char[10];
var tamanho = 0 ;

do
{
buffer = new char[10];
tamanho = sr.Read(buffer);

WriteLine($"{string.Join("", buffer)} - Buffer: {tamanho}");
    
} while (tamanho >= buffer.Length);

//executar um do ou outro do
/*
do
{
WriteLine(sr.ReadLine());
    
} while (sr.Peek() > 0);
*/
WriteLine("Digite [Enter] para finalizar");
ReadLine();


