<h1>Fundamentos do ASP.NET 6</h1>

> As aulas assistidas foram organizadas nos **commits**

<!--#region Sumário -->

<h2>Sumário</h2>

<ul>
    <li>
        <a href="#introducao-minimal">Introdução e Minimal APIs</a>
        <ul>
            <li><a href="#introducao">Introdução</a></li>
            <li><a href="#primeira-api">Rodando sua primeira API</a></li>
        </ul>
    </li>
</ul>

<!--#endregion -->

<!--#region Introdução e Minimal APIs -->

<h2 id="introducao-minimal">Introdução e Minimal APIs</h2>

<!--#region Introdução  -->

<h3 id="introducao">Introdução</h3>

```ps
dotnet version
6.0.300
```

<!--#endregion -->

<!--#region Rodando sua primeira API  -->

<h3 id="primeira-api">Rodando sua primeira API</h3>

Criar o modelo ASP.NET Core Empty:

```ps
dotnet new web -o MinhaApi

O modelo "ASP.NET Core Empty" foi criado com êxito.

Processando ações pós-criação...
Executando 'dotnet restore' em D:\Dev\Balta.io\.NET\ASP.NET6\MinhaApi\MinhaApi.csproj...
  Determinando os projetos a serem restaurados...
  D:\Dev\Balta.io\.NET\ASP.NET6\MinhaApi\MinhaApi.csproj restaurado (em 117 ms).
A restauração foi bem-sucedida.
```

Executar o projeto:

```ps
cd .\MinhaApi\
dotnet run

Compilando...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7249
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5178
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\Dev\Balta.io\.NET\ASP.NET6\MinhaApi\
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
```

Criar o modelo de arquivo de .NET .gitignore

```ps
dotnet new gitignore
```

<!--#endregion -->

<!--#endregion -->
