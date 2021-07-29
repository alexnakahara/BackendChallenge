# Introdução
Projeto desenvolvido para um desafio de backend.
### :rocket: Tecnologias:
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Swashbuckle](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
- [xUnit.net](https://xunit.net/)


## Problema
Construa uma aplicação que exponha uma api web que valide se uma senha é válida.

Requisitos:
- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
  - Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

Exemplo:  

```c#
IsValid("") // false  
IsValid("aa") // false  
IsValid("ab") // false  
IsValid("AAAbbbCc") // false  
IsValid("AbTp9!foo") // false  
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
```
## Como executar:
Execute os comandos abaixo e acesse https://localhost:5001/swagger

<b>CLI</b>

```CLI
dotnet build 
dotnet run --project BackendChallenge.API
```
![Image of Swagger](https://user-images.githubusercontent.com/48356414/127195227-ff31332f-50bc-4182-a09b-925abe1337ec.png)
> Acesso para a documentação swagger: "https://localhost:5001/swagger"

## Testes:
Para cada requisito de validação foi feito um teste e consequentemente um método. Escolhi manter cada uma das tentativas de teste para simular o cenário de exemplo, então quando os testes forem executados você verá este cenário: 

Cenário exemplo:
```c#
IsValid("") // false  
IsValid("aa") // false  
IsValid("ab") // false  
IsValid("AAAbbbCc") // false  
IsValid("AbTp9!foo") // false  
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
``` 

```CLI
Com falha! - Com falha:     7, Aprovado:     8, Ignorado:     0, Total:    15, Duração: 43 ms - BackendChallenge.UnitTests.dll (net5.0)
```
*CLI*

### Como executar os Testes:
<b>CLI</b>

```CLI
dotnet test
```
