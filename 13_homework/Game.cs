using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _13_homework
{
    internal class Game
    {
        private List<Player> players;
        private List<Karta> deck;
        private Random random = new Random();

        private static string[] masti = { "чирва","бубна","хреста","піка"};
        private static string[] values = {"6","7","8","9","10","валет","дама","король","туз" };

        public Game(string player1, string player2)
        {
            players = new List<Player>
        {
            new Player(player1),
            new Player(player2)
        };
            CreateDeck();
            ShuffleDeck();
            DealCards();
        }

        public Game(string player1, string player2, string player3, string player4)
        {
            players = new List<Player>
        {
            new Player(player1),
            new Player(player2),
            new Player(player3),
            new Player(player4)
       };
            CreateDeck();
            ShuffleDeck();
            DealCards();
        }

        private void CreateDeck()
        {
            deck = new List<Karta>();
            foreach (var mast in masti)
                foreach (var value in values)
                    deck.Add(new Karta(mast,value));
        }

        private void ShuffleDeck()
        {
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Karta temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        private void DealCards()
        {
            int playerIndex = 0;
            foreach (var card in deck)
            {
                players[playerIndex].Cards.Add(card);
                playerIndex = (playerIndex + 1) % players.Count; 
            }
        }


        private bool Checking()
        {
            if (players.Any(player => player.Cards.Count == 36))
            {
                return false; 
            }

            foreach (var player in players)
            {
                if (!player.HasCards())
                    return false;
            }

            return true;
        }


        public void printCards()
        {
            foreach (var item in deck)
            {
                Console.WriteLine(item);
            }
        }

        public void Play()
        {
            while (Checking())
            {
                Console.WriteLine(players[0].Cards.Count);
                Console.WriteLine(players[1].Cards.Count);
                Console.WriteLine(players[2].Cards.Count);
                Console.WriteLine(players[3].Cards.Count);
                Console.WriteLine();

                var playedCards = new List<(Player, Karta)>();

                foreach (var player in players)
                {
                    var card = player.PlayCard();
                    playedCards.Add((player, card));
                    Console.WriteLine($"{player.Name} грає {card}");
                }

                var winner = playedCards.OrderByDescending(pc => pc.Item2.GetValue()).First().Item1;

                foreach (var card in playedCards)
                {
                    winner.AddCards(card.Item2);
                }


                if (winner.Cards.Count == 36)
                {
                    Console.WriteLine($"{winner.Name} виграв гру!");
                    break;  
                }


                Console.WriteLine($"\n{winner.Name} виграв раунд і забирає карти!\n");
            }

            var gameWinner = players.OrderByDescending(p => p.Cards.Count).First();
            Console.WriteLine($"Переможець - {gameWinner.Name}!");
        }

    }
}