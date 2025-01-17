using System.Security.Claims;

namespace AtencionTramites.Model.Classes
{
	public interface IAuthContainerModel
	{
		string SecretKey { get; set; }

		string SecurityAlgorithm { get; set; }

		int ExpireMinutes { get; set; }

		Claim[] Claims { get; set; }
	}
}
