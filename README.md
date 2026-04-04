# MyLibrary

Простая библиотека для демонстрации CI/CD и Git workflow.

## Установка
```bash
dotnet add package MyLibrary
```

## Использование
```csharp
var calculator = new Calculator();
int result = calculator.Add(2, 3); // 5
```

## Разработка

Требования: .NET 10.0+
```bash
git clone https://github.com/edwardyum/MyLibrary.git
cd MyLibrary
dotnet build
dotnet test
```

## Контрибьюция

См. [CONTRIBUTING.md](CONTRIBUTING.md)

## Лицензия

MIT — см. [LICENSE](LICENSE)