# .NET 9 - Testando recursos

## OpenAPI Com Scalar

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

Juntando isso com o pacote Scalar.AspNetCore, é possível acessar a interface do Scalar para visualizar toda a documentação que foi gerada no JSON da OpenAPI

```
/scalar/v1
```

Sendo V1, na URL, a versão da documentação da OpenAPI. 



