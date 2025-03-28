using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using Hotels.Models;

[ServiceContract]
public interface IHotelService
{
    [OperationContract]
    Task<List<Hotel>> GetHotelsAsync();  // Отримати всі готелі

    [OperationContract]
    Task<Hotel> GetHotelByIdAsync(int id); // Отримати готель за ID

    [OperationContract]
    Task<bool> CreateHotelAsync(Hotel hotel); // Створити готель

    [OperationContract]
    Task<bool> UpdateHotelAsync(Hotel hotel); // Оновити готель

    [OperationContract]
    Task<bool> DeleteHotelAsync(int id); // Видалити готель
}
