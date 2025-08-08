namespace AppTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; } // Nome da chave Primária tem que ter Id (id é a chave primária)
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
