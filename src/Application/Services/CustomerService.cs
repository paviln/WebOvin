using WebOvin.Application.Dtos;
using WebOvin.Application.Interfaces;

namespace WebOvin.Application.Services;

class CustomerService : ICustomerService
{ 
    public CustomerDto GetCustomerById(string id)
    {
        CustomerDto customerDto = new(Name: "Jens");

        return customerDto;
    }
}
