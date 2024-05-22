namespace OpenApiDotnet9.WebApi.Models;

public class Teste
{
    public Guid? Id { get; private set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }

    public void SetId()
    {
        Id = Guid.NewGuid();
    }
}