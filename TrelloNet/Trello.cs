﻿using System;
using TrelloNet.Internal;

namespace TrelloNet
{
	public class Trello : ITrello
	{
		private readonly TrelloRestClient _restClient;

		public Trello(string key)
		{
			_restClient = new TrelloRestClient(key);

			Members = new Members(_restClient);
			Boards = new Boards(_restClient);
			Lists = new Lists(_restClient);
			Cards = new Cards(_restClient);
			Checklists = new Checklists(_restClient);
			Organizations = new Organizations(_restClient);
		}

		public IMembers Members { get; private set; }
		public IBoards Boards { get; private set; }
		public ILists Lists { get; private set; }
		public ICards Cards { get; private set; }
		public IChecklists Checklists { get; private set; }
		public IOrganizations Organizations { get; private set; }

		public void Authenticate(string token)
		{
			_restClient.Authenticate(token);
		}

		public Uri GetAuthenticationUrl(string applicationName)
		{
			return _restClient.GetAuthenticationlUrl(applicationName, AccessMode.ReadOnly);
		}
	}
}