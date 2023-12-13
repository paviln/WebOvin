using WebOvin.Application.Dtos;

namespace WebOvin.Application.Interfaces;

public interface ICustomerService
{
   public CustomerDto GetCustomerById(string id); 
}