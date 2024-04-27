/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 *
 * Interface Definitions for Business Logic Layer
 */
namespace Assessment1.PharmacyManagementLibrary.Repositories;

public interface IBaseRepository<T> where T : class
{
    List<T> GetAll();

    bool Update(T entity);
    bool Delete(T entity);

    T this[int index] { get; }
}

public interface IMedicalBaseRepository<T> : IBaseRepository<T> where T : class
{
    T? GetByName(string name);
}

public interface IManagementBaseRepository<T> : IBaseRepository<T> where T : class
{
    T? GetById(int id);
}

