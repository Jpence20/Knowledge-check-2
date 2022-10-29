using System;
namespace Videogames
{
	public class VideoGames
	{
		public string game;
		public string genre;
		public string publisher;
		public bool consoleExculsive;



		public VideoGame(string game, string genre, string publisher, bool consoleExculsive)
		{
			game = this.game;
			genre = this.genre;
			publisher = this.publisher;
			consoleExculsive = this.consoleExculsive;
		}


	}
}