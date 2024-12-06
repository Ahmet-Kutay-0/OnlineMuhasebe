using OnlineMuhasebeServer.Persistance.Context;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Persistance.Context;
using OnlineMuhasebeServer.Application.Services.AppServices;

namespace OnlineMuhasebeServer.Persistance.Services.AppServices
{
    public sealed class CompanyService : ICompanyService
    {
        private readonly AppDbContext _context;

        public Task CreateCompany(CreateCompanyRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
