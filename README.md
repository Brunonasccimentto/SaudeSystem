# SistemaSaude  

## Descrição  
O **SistemaSaude** é uma API RESTful desenvolvida em .NET 8.0 que gerencia informações de médicos, permitindo listar, buscar e filtrar médicos por especialidade. O projeto utiliza Entity Framework Core com SQLite como banco de dados e segue boas práticas de desenvolvimento, como injeção de dependência e tratamento de exceções.  

## Estrutura do Projeto  
A estrutura do projeto está organizada da seguinte forma:  

```
SistemaSaude/  
├── Controllers/  
├── Data/  
├── Enums/  
├── Filter/  
├── Migrations/  
├── Model/  
├── Repository/  
├── Properties/  
├── Program.cs  
├── appsettings.json  
├── SistemaSaude.csproj  
└── SistemaSaude.db  
```  

### Principais Diretórios  
- **Controllers**: Contém os controladores da API, como `SistemaSaudeController.cs`.  
- **Data**: Contém o contexto do banco de dados, `SistemaSaudeDbContext.cs`.  
- **Enums**: Define enums utilizados no projeto, como `Roles.cs`.  
- **Filter**: Contém filtros globais, como `ExceptionHandler.cs`, para tratamento de exceções.  
- **Migrations**: Contém as migrações do Entity Framework Core.  
- **Model**: Define os modelos de dados, como `Doctor.cs` e `User.cs`.  
- **Repository**: Contém a lógica de acesso a dados, como `DoctorRepository.cs`.  

## Funcionalidades  
- Listar todos os médicos com paginação opcional.  
- Filtrar médicos por especialidade.  
- Buscar médicos pelo nome.  
- Tratamento de exceções globais.  
- Documentação Swagger integrada.  

## Tecnologias Utilizadas  
- **.NET 8.0**  
- **Entity Framework Core**  
- **SQLite**  
- **Swagger (Swashbuckle)**  
- **xUnit** para testes unitários.  

## Configuração do Ambiente  

### Pré-requisitos  
- .NET SDK 8.0 ou superior.  
- SQLite instalado (opcional, para manipulação direta do banco).  

### Passos para Configuração  
1. Clone o repositório:  
    ```bash  
    git clone https://github.com/Brunonasccimentto/SaudeSystem.git  
    cd SistemaSaude/SistemaSaudeProject  
    ```  

2. Restaure as dependências:  
    ```bash  
    dotnet restore  
    ```  

3. Execute as migrações para criar o banco de dados:  
    ```bash  
    dotnet ef database update  
    ```  

4. Inicie o servidor:  
    ```bash  
    dotnet run  
    ```  

5. Acesse a documentação Swagger em:  
    ```
    http://localhost:5160/swagger  
    ```  

## Endpoints  

### Listar Médicos  
**GET** `/api/SistemaSaude/listar-Medicos`  
- **Query Params**: `size` (opcional)  

### Filtrar Médicos por Especialidade  
**GET** `/api/SistemaSaude/listar-Medicos/{especialidade}`  
- **Path Params**: `especialidade`  

### Buscar Médico por Nome  
**GET** `/api/SistemaSaude/buscar-Medico/{nome}`  
- **Path Params**: `nome`  

## Testes  
Os testes unitários estão localizados no projeto `SistemaSaudeTest`. Para executar os testes:  
```bash  
dotnet test  
```  

## Contribuição  
Contribuições são bem-vindas! Siga os passos abaixo para contribuir:  
1. Faça um fork do repositório.  
2. Crie uma branch para sua feature ou correção:  
    ```bash  
    git checkout -b minha-feature  
    ```  
3. Faça o commit das suas alterações:  
    ```bash  
    git commit -m "Minha nova feature"  
    ```  
4. Envie para o repositório remoto:  
    ```bash  
    git push origin minha-feature  
    ```  
5. Abra um Pull Request.  

## Licença  
Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais informações.  

## Autor  
Desenvolvido por Bruno Rodrigues.  


