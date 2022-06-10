using static System.Console;
using System.IO;

var path = "C:\\Users\\thiago.goncalves\\Downloads\\dio\\dio-csharp\\Diretorios\\mundo";
using var fsw = new FileSystemWatcher(path);

fsw.Created += onCreated;
fsw.Deleted += onDeleted;
fsw.Renamed += onRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

WriteLine("Pressione o [Enter] para sair!");
ReadLine();

void onCreated(object sender, FileSystemEventArgs e)
{
   WriteLine($"Foi criado o arquivo {e.Name}");
}


void onDeleted(object sender, FileSystemEventArgs e)
{
   WriteLine($"Foi deletado o arquivo {e.Name}");
}


void onRenamed(object sender, RenamedEventArgs e)
{
   WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}