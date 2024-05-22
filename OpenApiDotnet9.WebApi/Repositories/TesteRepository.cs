using OpenApiDotnet9.WebApi.Models;

namespace OpenApiDotnet9.WebApi.Repositories;

public class TesteRepository
{
    private readonly List<Teste> _testes = new();
    
    
    public TesteRepository()
    {
        
    }

    public IEnumerable<Teste> GetTestes()
    {
        return _testes;
    }
    public IEnumerable<Teste> GetTestes(Guid id)
    {
        return _testes.Where(p => p.Id == id);
    }
    public void InsertTeste(Teste teste)
    {
        teste.SetId();
        _testes.Add(teste);
    }
    
}

