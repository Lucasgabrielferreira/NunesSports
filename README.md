<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <h1>NunesSports</h1>

  <h2>Descrição</h2>
    <p>NunesSports é uma aplicação ASP.NET Core MVC para gerenciar produtos esportivos. Ela permite a criação, leitura, atualização e exclusão (CRUD) de produtos, com suporte para upload de imagens.</p>

  <h2>Funcionalidades</h2>
    <ul>
        <li>Listagem de produtos com detalhes como nome, código, descrição, preço e imagem.</li>
        <li>Adição de novos produtos.</li>
        <li>Edição de produtos existentes.</li>
        <li>Exclusão de produtos.</li>
        <li>Upload de imagens de produtos.</li>
    </ul>

  <h2>Tecnologias Utilizadas</h2>
    <ul>
        <li>ASP.NET Core MVC</li>
        <li>Entity Framework Core</li>
        <li>Bootstrap</li>
        <li>SQL Server</li>
    </ul>

  <h2>Como Executar</h2>
    <ol>
        <li>Clone o repositório:
            <pre><code>git clone https://github.com/seu-usuario/nunessports.git</code></pre>
        </li>
        <li>Configure a string de conexão no <code>appsettings.json</code>.</li>
        <li>Execute as migrações do Entity Framework:
            <pre><code>dotnet ef database update</code></pre>
        </li>
        <li>Inicie o projeto:
            <pre><code>dotnet run</code></pre>
        </li>
   </ol>

  <h2>Estrutura do Projeto</h2>
  <ul>
        <li><strong>Controllers:</strong> Lógica para manipulação de produtos.</li>
        <li><strong>Models:</strong> Representação dos dados dos produtos.</li>
        <li><strong>Views:</strong> Interface de usuário para CRUD de produtos.</li>
  </ul>

   <h2>Contribuição</h2>
  <p>Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.</p>

  <h2>Licença</h2>
  <p>Este projeto é licenciado sob a <a href="https://github.com/Lucasgabrielferreira">Lucas gabriel Ferreira</a>.</p>
</body>
</html>

