<h1>Fundamentos do ASP.NET 6</h1>

> As aulas assistidas foram organizadas nos **commits**

<!--#region Sumário -->

<h2>Sumário</h2>

<details><summary>Introdução e Minimal APIs</summary>

<ul>
    <li><a href="#introducao">Introdução</a></li>
    <li><a href="#primeira-api">Rodando sua primeira API</a></li>
    <li><a href="#protocolos">Protocolo HTTP, DNS e Fundamentos</a></li>
</ul>

</details>

<!--#endregion -->

<!--#region Introdução e Minimal APIs -->

<h2 id="introducao-minimal">Introdução e Minimal APIs</h2>

<!--#region Introdução  -->

<details id="introducao"><summary>Introdução</summary>

<br/>

```ps
dotnet version
6.0.300
```

</details>

<!--#endregion -->

<!--#region Rodando sua primeira API  -->

<details id="primeira-api"><summary>Rodando sua primeira API</summary>

<br/>

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

Criar o modelo de arquivo de .NET .gitignore:

```ps
dotnet new gitignore
```

</details>

<!--#endregion -->

<!-- #region Protocolo HTTP, DNS e Fundamentos -->

<details id="protocolos"><summary>Protocolo HTTP, DNS e Fundamentos</summary>

<br/>

<h3>HTTP - Hypertext Transfer Protocol</h3>

<p>O <b>Hypertext Transfer Protocol</b>, sigla <b>HTTP</b> (em português <b>Protocolo de Transferência de Hipertexto</b>) é um protocolo de comunicação (na camada de aplicação segundo o <b>Modelo OSI</b>) utilizado para sistemas de informação de hipermídia, distribuídos e colaborativos. Ele é a base para a comunicação de dados da <b>World Wide Web</b>.</p>

<p><b>Hipertexto</b> é o texto estruturado que utiliza ligações lógicas (<b>hiperlinks</b>) entre <b>nós</b> contendo texto. O HTTP é o protocolo para a troca ou transferência de hipertexto.</p>

<br/>

<h3>HTTPS - Hypertext Transfer Protocol Secure</h3>

<p><b>HTTPS<b/> (<b>Hypertext Transfer Protocol Secure</b> - <b>protocolo de transferência de hipertexto seguro</b>) é uma implementação do <b>protocolo HTTP</b> sobre uma camada adicional de segurança que utiliza o protocolo <b>SSL/TLS</b>. Essa camada adicional permite que os dados sejam transmitidos por meio de uma <b>conexão criptografada</b> e que se verifique a autenticidade do servidor e do cliente por meio de <b>certificados digitais</b>. A porta TCP usada por norma para o protocolo HTTPS é a 443.</p>

<p>O <b>protocolo HTTPS</b> é utilizado, em regra, quando se deseja evitar que a informação transmitida entre o cliente e o servidor seja visualizada por terceiros, como por exemplo no caso de compras online. A existência na barra de endereços de um cadeado (que pode ficar do lado esquerdo ou direito, dependendo do navegador utilizado) demonstra a certificação de página segura (<b>SSL/TLS</b>). A existência desse certificado indica o uso do <b>protocolo HTTPS</b> e que a comunicação entre o browser e o servidor se dará de forma segura. Para verificar a identidade do servidor é necessário um duplo clique no cadeado para exibição do certificado.</p>

<p>Nas URLs dos sites o início ficaria <b>https://</b></p>

<p>Conexões <b>HTTPS</b> são frequentemente usadas para <b>transações de pagamentos</b> na <b>World Wide Web</b> e para <b>transações sensíveis</b> em sistemas de informação corporativos. Porém, o <b>HTTPS</b> não deve ser confundido com o <b>protocolo "Secure HTTP" (S-HTTP)</b>, especificado na RFC 2660 e raramente utilizado.</p>

</details>

<!--#endregion -->

<!--#endregion -->
