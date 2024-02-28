using DemoBlazor.Library;
using DemoBlazor.Library.Interfaces;

namespace DemoBlazorWASM.Services;

public class ServizioDati : IDatiEventi
{
    public List<Evento> EstraiEventiFuturi()
    {
        return new List<Evento> {
        new Evento { Id = 1, Nome = "Evento 1", Data = DateTime.Now },
        new Evento { Id = 2, Nome = "Evento 2", Data = DateTime.Now },
        new Evento { Id = 3, Nome = "Evento 3", Data = DateTime.Now },
        new Evento { Id = 4, Nome = "Evento 4", Data = DateTime.Now },
        new Evento { Id = 5, Nome = "Evento 5", Data = DateTime.Now },
        new Evento { Id = 6, Nome = "Evento 6", Data = DateTime.Now },
        new Evento { Id = 7, Nome = "Evento 7", Data = DateTime.Now },
        new Evento { Id = 8, Nome = "Evento 8", Data = DateTime.Now },
        new Evento { Id = 9, Nome = "Evento 9", Data = DateTime.Now },
        new Evento { Id = 10, Nome = "Evento 10", Data = DateTime.Now }
    };
    }

    public List<Evento> EstraiEventiPassati()
    {
        return new List<Evento>
        {
         new Evento { Id = 100, Nome = "Evento 100", Data = DateTime.Now.AddDays(-7) },
        };
    }
}
