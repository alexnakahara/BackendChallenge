# Introdução 

<b>Projeto desenvolvido para desafio de backend. Foi utilizado [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) </b>


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
Execute os comandos abaixo e acesse a documentação [Swagger](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0) no navegador.

<b>CLI</b>
```cli
dotnet build 
dotnet run --project BackendChallenge.API
```
> Acesso para a documentação swagger: "https://localhost:5001/swagger"

![Image of Swagger](https://user-images.githubusercontent.com/48356414/127195227-ff31332f-50bc-4182-a09b-925abe1337ec.png)
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

```cli
"Com falha! - Com falha:     7, Aprovado:     8, Ignorado:     0, Total:    15, Duração: 43 ms - BackendChallenge.UnitTests.dll (net5.0)"
```
*CLI*

### Como executar os Testes:
<b>CLI</b>
```cli
dotnet build // caso não tenha feito o build ainda
dotnet test

```

## Considerações 
Por se tratar de uma solução simples sem persistências de dados e com poucas entidades optei por não definir uma arquitetura, mas sim design simples com Controllers, Services, Interfaces e Models.

