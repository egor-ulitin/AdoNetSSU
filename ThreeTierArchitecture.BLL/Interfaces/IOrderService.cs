using System.Collections.Generic;
using ThreeTierArchitecture.BLL.DTO;

namespace ThreeTierArchitecture.BLL.Interfaces
{
    public interface IOrderService
    {
        void MakeOrder(OrderDTO orderDto);
        PhoneDTO GetPhone(int? id);
        IEnumerable<PhoneDTO> GetPhones();
        void Dispose();
    }
}
