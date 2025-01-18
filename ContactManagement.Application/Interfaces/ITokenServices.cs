using ContactManagement.Domain.Entities;

namespace ContactManagement.Application.Interfaces
{
	public interface ITokenService
    {
        Task<string> GetToken(User user); // M�todo deve ser ass�ncrono
    }
}
