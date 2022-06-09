
using static System.Console;

WriteLine("Digite o nome do arquivo:");
var nome = ReadLine();

LimparNome(ref nome);
//var path = Environment.CurrentDirectory + "\\teste.txt";
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);


static void LimparNome(ref string nome)
{
if (string.IsNullOrEmpty(nome))
{
    nome = "Sem-Nome";
}
foreach (var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
    
}

}
static void CriarArquivo(string path)
{
    try
    {

    //File.Create(path); //apenas cria o arquivo
    using var sw = File.CreateText(path);
    sw.WriteLine("Essa é a primeira linha do arquivo");
    sw.WriteLine("Essa é a segundo linha do arquivo");
    // sw.Flush(); utilizand o using antes do var, utiliza o IDisposable e o flush é automatico
    }
    catch (System.Exception)
    {
        WriteLine("O nome do arquivo está incorreto.");
        //throw;
    }
    finally
    {
        WriteLine("Digite enter para terminar");
        ReadLine();
    }

}