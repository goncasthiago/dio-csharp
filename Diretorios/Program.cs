//using System.IO; //nao precisa pq esta carregando automaticamente
using static System.DateTime;
using static System.Console;

//Criando os diretorios
CriarDiretoriosMundo();
//Criando o arquivo brasil
var arquivoI = "Brasil";
CriarArquivo(arquivoI, "213MM", "0,901");
var arquivoII = "Argentina";
CriarArquivo(arquivoII, "213MM", "0,901");

//declarando as pastas
var origemI = Path.Combine(Environment.CurrentDirectory, $"{arquivoI}.txt");
var destinoI = Path.Combine(Environment.CurrentDirectory, "mundo", "America do Sul", arquivoI, $"{arquivoI}.txt");
var origemII = Path.Combine(Environment.CurrentDirectory, $"{arquivoII}.txt");
var destinoII = Path.Combine(Environment.CurrentDirectory, "mundo", "America do Sul", arquivoII, $"{arquivoII}.txt");

MoveArquivo(origemI, destinoI);
CopiaArquivo(origemI, destinoI);
MoveArquivo(origemII, destinoII);
CopiaArquivo(origemII, destinoII);

var path = Path.Combine(Environment.CurrentDirectory, "mundo");
LerDiretorios(path);
WriteLine(path);
var pathArquivos = Path.Combine(Environment.CurrentDirectory,"mundo");
LerArquivos(pathArquivos);
WriteLine("Digite [Enter] para finalizar");
ReadLine();


static void LerArquivos(string pathArquivo)
{
    if (Directory.Exists(pathArquivo))
    {
        var arquivos = Directory.GetFiles(pathArquivo, "*", SearchOption.AllDirectories);
        foreach (var arq in arquivos)
        {
            var arquivoInfo = new FileInfo(arq);
            if (arquivoInfo.DirectoryName != null)
                WriteLine($"[Pai]: {arquivoInfo.DirectoryName}");
            WriteLine($"[Nome]: {arquivoInfo.Name}");
            WriteLine($"[Extensão]: {arquivoInfo.Extension}");
            WriteLine("------------");
        }

    }
    else{
        WriteLine("Diretório não encontrado!");
    }


}



static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            if (dirInfo.Parent != null)
                WriteLine($"[Pai]: {dirInfo.Parent.Name}");
            WriteLine($"[Nome]: {dirInfo.Name}");
            WriteLine($"[Raiz]: {dirInfo.Root.FullName}");
            WriteLine("------------");
        }

    }
    else{
        WriteLine("Diretório não encontrado!");
    }


}

static void MoveArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo não existe na Origem");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta Destino");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}
static void CopiaArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo não existe na Origem");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta Destino");
        return;
    }

    File.Copy(pathOrigem, pathDestino);
}
static void CriarArquivo(string pais, string populacao, string idh)
{
    var path = Path.Combine(Environment.CurrentDirectory, $"{pais}.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        var data = DateTime.Now;

        sw.WriteLine($"População: {populacao}");
        sw.WriteLine($"IDH: {idh}");
        sw.WriteLine($"Data de Atualização: {data}");
    }
}

static void CriarDiretoriosMundo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "mundo");
    if (!Directory.Exists(path))
    {
        var dirMundo = Directory.CreateDirectory(path);

        var dirAmNorte = dirMundo.CreateSubdirectory("America do Norte");
        var dirAmCentral = dirMundo.CreateSubdirectory("America Central");
        var dirAmSul = dirMundo.CreateSubdirectory("America do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Canada");
        dirAmNorte.CreateSubdirectory("Mexico");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Chile");

    }


}

