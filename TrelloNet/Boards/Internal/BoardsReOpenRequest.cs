using RestSharp;

namespace TrelloNet.Internal
{
	internal class BoardsReOpenRequest : BoardRequest
	{
		public BoardsReOpenRequest(IBoardId board)
			: base(board, "closed", Method.PUT)
		{
			this.AddValue("false");			
		}
	}
}