
namespace GalloFlix.Interfaces;

public interface IRepository<T> where T : class
{
    // CRUD: CREATE, READ, UPDATE, DELETE

    // CREATE - Adicionar novo dado
    void Create(T model);

    // READ - Leitura de dados
    List<T> ReadAll();
    T ReadById(int? id);

    // UPDATE - Atualizar um Dado
    void Update(T model);

    // DELETE - Excluir dados
    void Delete(int? id);
}
