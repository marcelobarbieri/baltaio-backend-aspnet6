<h1>Fundamentos do ASP.NET 6</h1>

> As aulas assistidas foram organizadas nos **commits**

<!--#region Sumário -->

<h2>Sumário</h2>

<details><summary>Introdução e Minimal APIs</summary>

<ul>
    <li><a href="#introducao">Introdução</a></li>
    <li><a href="#primeira-api">Rodando sua primeira API</a></li>
    <li><a href="#protocolos">Protocolo HTTP, DNS e Fundamentos</a></li>
    <li><a href="#verbos">Entendendo os Verbos HTTP</a></li>
    <li><a href="#status-code">HTTP Status Code</a></li>
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

<p><b>HTTPS</b> (<b>Hypertext Transfer Protocol Secure</b> - <b>protocolo de transferência de hipertexto seguro</b>) é uma implementação do <b>protocolo HTTP</b> sobre uma camada adicional de segurança que utiliza o protocolo <b>SSL/TLS</b>. Essa camada adicional permite que os dados sejam transmitidos por meio de uma <b>conexão criptografada</b> e que se verifique a autenticidade do servidor e do cliente por meio de <b>certificados digitais</b>. A porta TCP usada por norma para o protocolo HTTPS é a 443.</p>

<p>O <b>protocolo HTTPS</b> é utilizado, em regra, quando se deseja evitar que a informação transmitida entre o cliente e o servidor seja visualizada por terceiros, como por exemplo no caso de compras online. A existência na barra de endereços de um cadeado (que pode ficar do lado esquerdo ou direito, dependendo do navegador utilizado) demonstra a certificação de página segura (<b>SSL/TLS</b>). A existência desse certificado indica o uso do <b>protocolo HTTPS</b> e que a comunicação entre o browser e o servidor se dará de forma segura. Para verificar a identidade do servidor é necessário um duplo clique no cadeado para exibição do certificado.</p>

<p>Nas URLs dos sites o início ficaria <b>https://</b></p>

<p>Conexões <b>HTTPS</b> são frequentemente usadas para <b>transações de pagamentos</b> na <b>World Wide Web</b> e para <b>transações sensíveis</b> em sistemas de informação corporativos. Porém, o <b>HTTPS</b> não deve ser confundido com o <b>protocolo "Secure HTTP" (S-HTTP)</b>, especificado na RFC 2660 e raramente utilizado.</p>

</details>

<!--#endregion -->

<!-- #region Entendendo os Verbos HTTP -->

<details id="verbos"><summary>Entendendo os Verbos HTTP</summary>

<br/>

<p>Ferramenta: <a href="https://postman.com">https://postman.com</a></p>

<p>Referência: <a href="https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Methods">https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Methods</a></p>

<h3>Métodos de requisição:</h3>

<p>O protocolo HTTP define um conjunto de <b>métodos de requisição</b> responsáveis por indicar a ação a ser executada para um dado recurso. Embora esses métodos possam ser descritos como substantivos, eles também são comumente referenciados como <b>HTTP Verbs (Verbos HTTP)</b>. Cada um deles implementa uma semântica diferente, mas alguns recursos são compartilhados por um grupo deles, como por exemplo, qualquer método de requisição pode ser do tipo <b>safe, idempotent ou cacheable (en-US)</b>.</p>

<h4>GET</h4>
<p>O método GET solicita a representação de um recurso específico. Requisições utilizando o método GET devem retornar apenas dados.</p>

<h4>HEAD</h4>
<p>O método HEAD solicita uma resposta de forma idêntica ao método GET, porém sem conter o corpo da resposta.</p>

<h4>POST</h4>
<p>O método POST é utilizado para submeter uma entidade a um recurso específico, frequentemente causando uma mudança no estado do recurso ou efeitos colaterais no servidor.</p>

<h4>PUT</h4>
<p>O método PUT substitui todas as atuais representações do recurso de destino pela carga de dados da requisição.</p>

<h4>DELETE</h4>
<p>O método DELETE remove um recurso específico.</p>

<h4>CONNECT</h4>
<p>O método CONNECT estabelece um túnel para o servidor identificado pelo recurso de destino.</p>

<h4>OPTIONS</h4>
<p>O método OPTIONS é usado para descrever as opções de comunicação com o recurso de destino.</p>

<h4>TRACE</h4>
<p>O método TRACE executa um teste de chamada loop-back junto com o caminho para o recurso de destino.</p>

<h4>PATCH</h4>
<p>O método PATCH é utilizado para aplicar modificações parciais em um recurso.</p>

</details>

<!--#endregion -->

<!-- #region HTTP Status Code -->

<details id="status-code"><summary>HTTP Status Code</summary>

<br/>

<p>Referência: <a href="https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status">Códigos de status de respostas HTTP</a></p>

<p>Os códigos de status das respostas HTTP indicam se uma requisição HTTP foi corretamente concluída.</p>

<p>As respostas são agrupadas em cinco classes:</p>

<ol type="A">
    <li>
        Respostas de informação (100-199)
        <ol type="1">
            <li>100 Continue</li>
            <li>101 Switching Protocol</li>
            <li>102 Processing</li>
            <li>103 Early Hints</li>
        </ol>
    </li>
    <li>
        Respostas de sucesso (200-299)
        <ol type="1">
            <li>200 OK</li>            
            <li>201 Created</li>            
            <li>202 Accepted</li>      
            <li>203 Non-Authoritative Information</li>                  
            <li>204 No Content</li>
            <li>205 Reset Content</li>
            <li>206 Partial Content</li>
            <li>207 Multi-Status</li>
            <li>208 Multi-Status</li>
            <li>226 IM Used</li>
        </ol>
    </li>
    <li>
        Redirecionamentos (300-399)
        <ol type="1">
            <li>300 Multiple Choice</li>            
            <li>301 Moved Permanently</li>
            <li>302 Found</li>
            <li>303 See Other</li>
            <li>304 Not Modified</li>
            <li>305 Use Proxy</li>
            <li>306 Unused</li>
            <li>307 Temporary Redirect</li>
            <li>308 Permanent Redirect</li>
        </ol>        
    </li>
    <li>
        Erros do cliente (400-499)
        <ol type="1">
            <li>400 Bad Request</li>
            <li>401 Unauthorized</li>
            <li>402 Payment Required</li>
            <li>403 Forbidden</li>
            <li>404 Not Found</li>
            <li>405 Method Not Allowed</li>
            <li>406 Not Acceptable</li>
            <li>407 Proxy Authentication Required</li>
            <li>408 Request Timeout</li>
            <li>409 Conflict</li>
            <li>410 Gone</li>
            <li>411 Length Required</li>
            <li>412 Precondition Failed</li>
            <li>413 Payload Too Large</li>
            <li>414 URI Too Long</li>
            <li>415 Unsupported Media Type</li>
            <li>416 Requested Range Not Satisfiable</li>
            <li>417 Expectation Failed</li>
            <li>418 I´m a teapot</li>
            <li>421 Misdirected Request</li>
            <li>422 Unprocessable Entity</li>
            <li>423 Locked</li>
            <li>424 Failed Dependency</li>
            <li>425 Too Early</li>
            <li>426 Upgrade Required</li>
            <li>428 Precondition Required</li>
            <li>429 Too May Requests</li>
            <li>431 Request Header Fields Too Large</li>
            <li>451 Unavailable For Legal Reasons</li>
        </ol>                
    </li>
    <li>
        Erros do servidor (500-599)
        <ol type="1">
            <li>500 Internal Server Error</li>
            <li>501 Not Implemented</li>
            <li>502 Bad Gateway</li>
            <li>503 Service Unavailable</li>
            <li>504 Gateway Timeout</li>
            <li>505 HTTP Version Not Supported</li>
            <li>506 Variant Also Negotiates</li>
            <li>507 Insufficient Storage</li>
            <li>508 Loop Detected</li>
            <li>510 Not Extended</li>
            <li>511 Network Authentication Required</li>
        </ol>
    </li>
</ol>
<!--#endregion -->

<!--#endregion -->
