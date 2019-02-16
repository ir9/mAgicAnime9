using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicAnime
{
	class MainFormController
	{
		public IReadOnlyList<AnimeProgram> GetProgramList(string filter)
		{
			AnimeServer	server = AnimeServer.GetInstance();
			if (string.IsNullOrWhiteSpace(filter))
				return server.Animes;

			return server.Animes.Where((a) => a.title.Contains(filter)).ToList();
		}
	}
}


