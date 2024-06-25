using Domain.Entities;

namespace Application.Interfaces;

public interface IPersonRepository
{
    /// <summary>
    /// Создание персон.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <returns>Новая сущность</returns>
    public Person Create(Person entity);

    /// <summary>
    /// Получение персоны по ID.
    /// </summary>
    /// <param name="id">Идентификатор.</param>
    /// <returns>Сущность</returns>
    public Person GetById(Guid id);
    
    /// <summary>
    /// Обновление персоны.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <returns>Обновленная сущность</returns>
    public Person Update(Person entity);
    
    /// <summary>
    /// Удаление персоны.
    /// </summary>
    /// <param name="id">Идентификатор.</param>
    public void Delete(Guid id);
    
    /// <summary>
    /// Получтение всех персон.
    /// </summary>
    /// <returns>List содержащий все сущности</returns>
    public List<Person> GetAll();

    /// <summary>
    /// Сохранение изменений.
    /// </summary>
    public Task SaveChanges();
}