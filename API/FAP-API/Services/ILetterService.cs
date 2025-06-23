using FAP_API.Models;

namespace FAP_API.Services
{
	public interface ILetterService
	{
		public List<Letter> GetLetterList();
		List<Letter> GetLettersByUserId(string userId);


	}
}
