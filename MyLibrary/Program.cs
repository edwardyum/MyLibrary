using Velopack;
using Velopack.Sources;

VelopackApp.Build().Run();

var mgr = new UpdateManager(
    new GithubSource("https://github.com/edwardyum/MyLibrary", null, false));

Console.WriteLine("Проверяем обновления...");
var newVersion = await mgr.CheckForUpdatesAsync();

if (newVersion != null)
{
    Console.WriteLine($"Доступна новая версия: {newVersion.TargetFullRelease.Version}");
    Console.WriteLine("Устанавливаем обновление...");
    await mgr.DownloadUpdatesAsync(newVersion);
    mgr.ApplyUpdatesAndRestart(newVersion);
}
else
{
    Console.WriteLine("Обновлений нет.");
}

var calculator = new MyLibrary.Calculator();
Console.WriteLine($"2 + 3 = {calculator.Add(2, 3)}");
Console.WriteLine($"10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"3 * 4 = {calculator.Multiply(3, 4)}");
Console.WriteLine("Версия 0.6.0 — новые функции добавлены!");
Console.WriteLine("Нажмите любую клавишу...");
Console.ReadKey();