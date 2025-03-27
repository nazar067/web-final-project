using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Serialization;
using Hotels.Models;

namespace Hotels.Services
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface IHotelService
    {
        [OperationContract]
        List<Hotel> GetHotels();

        [OperationContract]
        Hotel GetHotelById(int id);

        [OperationContract]
        void AddHotel(Hotel hotel);

        [OperationContract]
        void UpdateHotel(Hotel hotel);

        [OperationContract]
        void DeleteHotel(int id);
    }
}
