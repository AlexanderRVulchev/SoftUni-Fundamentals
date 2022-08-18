//You will be given two hands of cards, which will be integer numbers.
//Assume that you have two players.
//You have to find out the winning deck and respectively the winner.
//You start from the beginning of both hands.
//Compare the cards from the first deck to the cards from the second deck.
//The player, who has the bigger card, takes both cards and puts them at the back of his hand
//- the second player’s card is last, and the first person’s card (the winning one)
//is before it (second to last) and the player with the smaller card must remove the card from his deck.
//If both players’ cards have the same values -
//no one wins, and the two cards must be removed from the decks.
//The game is over, when one of the decks is left without any cards.
//You have to print the winner on the console and the sum of the left cards:
//"{First/Second} player wins! Sum: {sum}".

using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static (List<int>, List<int>) CardShuffleWhenHandIsWon(List<int> winningDeck, List<int> losingDeck)
    {
        winningDeck.Add(winningDeck[0]);
        winningDeck.Add(losingDeck[0]);
        winningDeck.RemoveAt(0);
        losingDeck.RemoveAt(0);
        return (winningDeck, losingDeck);
    }

    static void Main()
    {
        List<int> player1Deck = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> player2Deck = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (player1Deck.Count > 0 && player2Deck.Count > 0)
        {
            if (player1Deck[0] > player2Deck[0])
                (player1Deck, player2Deck) = CardShuffleWhenHandIsWon(player1Deck, player2Deck);
            else if (player1Deck[0] < player2Deck[0])
                (player2Deck, player1Deck) = CardShuffleWhenHandIsWon(player2Deck, player1Deck);
            else
            {
                player1Deck.RemoveAt(0);
                player2Deck.RemoveAt(0);
            }
        }

        if (player2Deck.Count == 0) Console.WriteLine($"First player wins! Sum: {player1Deck.Sum()}");
        else Console.WriteLine($"Second player wins! Sum: {player2Deck.Sum()}");
    }
}