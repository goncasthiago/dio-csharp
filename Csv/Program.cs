using static System.Console;
CriaCSV();

static void CriaCSV()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");
    var pessoas = new List<Pessoa>(){
        new Pessoa(
            "Thiago",
            "thiago@email.com",
            123456,
            new DateOnly(year: 1983, month: 9, day:16)
        ),
        new Pessoa(
            "Juliana",
            "Juliana@email.com",
            123456,
            new DateOnly(year: 1983, month: 9, day:15)
        ),
        new Pessoa(
            "Arthur",
            "arthur@email.com",
            123456,
            new DateOnly(year: 2013, month: 11, day:10)
        ),
    };

    var di = new DirectoryInfo(path);

    if (!di.Exists)
    {
        di.Create();
    }
    path = Path.Combine(Environment.CurrentDirectory, "Saida", "pessoas.csv");

    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = ($"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}");
        sw.WriteLine(linha);
    }





}

static void LeCSV()
{

    //montando o path do arquivo
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "aprovados.csv");

    if (File.Exists(path))
    {

        //carregando o arquivo no buffer com o stream reader
        using var sr = new StreamReader(path);

        var cabecalho = sr.ReadLine()?.Split(',');

        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            for (int i = 0; i < cabecalho.Length; i++)
            {
                WriteLine($"{cabecalho?[i]}:{registro[i]}");
            }
            WriteLine("----------");

        }

        WriteLine("Aperte [Enter] para finalizar...");
        ReadLine();

    }
    else
    {
        WriteLine($"Arquivo: {path} não encontrado!");
    }
}

class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public int? Telefone { get; set; }
    public DateOnly? Nascimento { get; set; }

    public Pessoa(string nome, string email, int telefone, DateOnly nascimento)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Nascimento = nascimento;
    }

}
