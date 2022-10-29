using System;

public class VideoGames
{
	public string name { get; set; }
	public string genre { get; set; }
	public string publisher { get; set; }
	public string consoleExclusive { get; set; }

	public VideoGames(string gameName, string gameGenre,string gamePublisher, string gameConsoleExculsive)
	{
		gameName = this.name;
		gameGenre = this.genre;
		gamePublisher = this.publisher;
		gameConsoleExculsive = this.consoleExclusive;
	}


}
