﻿using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    /// <summary>
    /// Riot Client
    /// </summary>
    public class RiotClient : IRiotClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiotClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        public RiotClient(string apiKey)
        {
            IChampion champion = new Champion(apiKey);
            ICurrentGame currentGame = new CurrentGame(apiKey);
            IFeaturedGames featuredGames = new FeaturedGames(apiKey);
            IGame game = new Game(apiKey);
            ILeague league = new League(apiKey);
            ILolStaticData lolStaticData = new LolStaticData(apiKey);
            ILolStatus lolStatus = new LolStatus();
            IMatch match = new Match(apiKey);
            IMatchHistory matchHistory = new MatchHistory(apiKey);
            IMatchList matchList = new MatchList(apiKey);
            IStats stats = new Stats(apiKey);
            ISummoner summoner = new Summoner(apiKey);
            ITeam team = new Team(apiKey);

            this.Champion = champion;
            this.CurrentGame = currentGame;
            this.FeaturedGames = featuredGames;
            this.Game = game;
            this.League = league;
            this.LolStaticData = lolStaticData;
            this.LolStatus = lolStatus;
            this.Match = match;
            this.MatchHistory = matchHistory;
            this.MatchList = matchList;
            this.Stats = stats;
            this.Summoner = summoner;
            this.Team = team;
        }

        /// <summary>
        /// Constructs a Riot Client with given implemented service for each Riot service group.
        /// </summary>
        /// <param name="champion">The champion.</param>
        /// <param name="currentGame">The current game.</param>
        /// <param name="featuredGames">The featured games.</param>
        /// <param name="game">The game.</param>
        /// <param name="league">The league.</param>
        /// <param name="lolStaticData">The lol static data.</param>
        /// <param name="lolStatus">The lol status.</param>
        /// <param name="match">The match.</param>
        /// <param name="matchHistory">The match history.</param>
        /// <param name="matchList">The match list.</param>
        /// <param name="stats">The stats.</param>
        /// <param name="summoner">The summoner.</param>
        /// <param name="team">The team.</param>
        public RiotClient(IChampion champion, ICurrentGame currentGame, IFeaturedGames featuredGames, IGame game, ILeague league, ILolStaticData lolStaticData,
            ILolStatus lolStatus, IMatch match, IMatchHistory matchHistory, IMatchList matchList, IStats stats, ISummoner summoner, ITeam team)
        {
            this.Champion = champion;
            this.CurrentGame = currentGame;
            this.FeaturedGames = featuredGames;
            this.Game = game;
            this.League = league;
            this.LolStaticData = lolStaticData;
            this.LolStatus = lolStatus;
            this.Match = match;
            this.MatchHistory = matchHistory;
            this.MatchList = matchList;
            this.Stats = stats;
            this.Summoner = summoner;
            this.Team = team;
        }

        public IChampion Champion { get; set; }
        public ICurrentGame CurrentGame { get; set; }
        public IFeaturedGames FeaturedGames { get; set; }
        public IGame Game { get; set; }
        public ILeague League { get; set; }
        public ILolStaticData LolStaticData { get; set; }
        public ILolStatus LolStatus { get; set; }
        public IMatch Match { get; set; }
        public IMatchHistory MatchHistory { get; set; }
        public IMatchList MatchList { get; set; }
        public IStats Stats { get; set; }
        public ISummoner Summoner { get; set; }
        public ITeam Team { get; set; }
    }
}
