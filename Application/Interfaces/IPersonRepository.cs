using Domain.Entities;

namespace Application.Interfaces;

public interface IPersonRepository
{
    /// <summary>
    /// Создание
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Новая сущность</returns>
    public Person Create(Person entity);

    /// <summary>
    /// Прочтение
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Сущность</returns>
    public Person GetById(Guid id);
    
    /// <summary>
    /// Обновление
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Обновленную сущность</returns>
    public Person Update(Person entity);
    
    /// <summary>
    /// Удаление
    /// </summary>
    /// <param name="id"></param>
    /// <returns>bool результат</returns>
    public void DeleteById(Guid id);
    
    /// <summary>
    /// Получтение всего 
    /// </summary>
    /// <returns>List содержащий все сущности</returns>
    public List<Person> GetAllList();

    /// <summary>
    /// Сохранение 
    /// </summary>
    /// <returns>List содержащий все сущности</returns>
    public Task SaveChanges();
}