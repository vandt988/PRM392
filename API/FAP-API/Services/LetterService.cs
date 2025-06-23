using FAP_API.Models;

namespace FAP_API.Services
{
	public class LetterService : ILetterService
	{
		private readonly Prm392Context _context;

		public LetterService(Prm392Context context)
		{
			_context = context;
		}	

		public List<Letter> GetLetterList()
		{
			return _context.Letters.ToList();
		}

		public List<Letter> GetLettersByStatus(int status)
		{
			return _context.Letters.Where(l => l.Status == status).ToList();
		}

		public List<Letter> GetLettersByUserId(string userId)
		{
			return _context.Letters.Where(l => l.UserId == userId).ToList();
		}

		public bool UpdateLetterStatus(string letterId, int newStatus)
		{
			var letter = _context.Letters.FirstOrDefault(l => l.LetterId == letterId);
			if (letter == null) return false;

			letter.Status = newStatus;
			_context.SaveChanges();
			return true;
		}
	}
}
