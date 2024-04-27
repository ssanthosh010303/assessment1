/*
 * Author: Sakthi Santhosh
 * Created on: 22/04/2024
 *
 * Interface Definitions for Presentation Layer
 */
namespace Assessment1.PharmacyManagementLibrary.Services;

public interface IBaseService<T> where T : class
{
    List<T> GetAll();

    bool Update(T entity);
    bool Delete(T entity);
}

public interface IMedicalBaseService<T> : IBaseService<T> where T : class
{
    T? GetByName(string name);
}

public interface IManagementBaseService<T> : IBaseService<T> where T : class
{
    T? GetById(int id);
}
