using Microsoft.AspNetCore.Mvc.RazorPages;
using WebOvin.Application.Dtos;
using WebOvin.Application.Interfaces;

namespace WebOvin.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ICustomerService _customerService;
    public CustomerDto CustomerDto { get; set; }

    public IndexModel(ILogger<IndexModel> logger, ICustomerService customerService)
    {
        _logger = logger;
        _customerService = customerService;
    }

    public void OnGet()
    {
        CustomerDto = _customerService.GetCustomerById("1");
    }
}
