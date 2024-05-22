# .NET 9 - Testando recursos

## OpenAPI

O pacote Microsoft.AspNetCore.OpenApi fornece suporte interno para a geração de documentos OpenAPI no ASP.NET Core.

Na Program.cs:

```
// registra na services
builder.Services.AddOpenApi();
// registra no app
app.MapOpenApi();
```
A partir dessa configuração, poderá visualizar a URL para acessar o JSON com a documentação da sua API gerada automaticamente

```
/openapi/v1.json
```

## Scalar

Juntando isso com o pacote Scalar.AspNetCore, é possível acessar a interface do Scalar para visualizar toda a documentação que foi gerada no JSON da OpenAPI

Program.cs: 

```
app.MapScalarApiReference();
```
URL: 
```
/scalar/v1
```

Sendo V1, na URL, a versão da documentação da OpenAPI. 

## Swagger
Outra opção é usar o velho SwaggerUi com o OpenApi como interface para a doc da API.

Program.cs:
```
 app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
```


