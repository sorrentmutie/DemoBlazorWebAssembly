namespace DemoBlazor.Library.Interfaces;

public interface IDatiEventi
{
    List<Evento> EstraiEventiPassati();
    List<Evento> EstraiEventiFuturi();
}
