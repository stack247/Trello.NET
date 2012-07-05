using System.Collections.Generic;
using System.Threading.Tasks;
using TrelloNet.Internal;

namespace TrelloNet
{
	public interface IAsyncTrello
	{
		IAsyncMembers Members { get; }
		IAsyncBoards Boards { get; }
		IAsyncLists Lists { get; }
		IAsyncCards Cards { get; }
		IAsyncChecklists Checklists { get; }
		IAsyncOrganizations Organizations { get; }
		IAsyncNotifications Notifications { get; }
		IAsyncTokens Tokens { get; }
		IAsyncActions Actions { get; }
		Task<SearchResults> Search(string query, IEnumerable<ModelType> modelTypes = null, int limit = 10, SearchFilter filter = null);
	}
}