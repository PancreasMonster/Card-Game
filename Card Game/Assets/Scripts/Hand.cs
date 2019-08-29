using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public int numberOfCards;
    public List<GameObject> cards;
    bool endRound = false;
//    private static CardManager cardManager;

    void Start()
    {
        //       cardManager = FindObjectOfType<CardManager>();
        numberOfCards = cards.Count;
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown(KeyCode.R) && endRound == false)
        { 
            endRound = true;
            RoundEnd();
        }
    }

    public DiscardPile discardPile;
    public Deck deck;

    public void RoundEnd()
    {
        numberOfCards = cards.Count;

        for (int h = 0; h < numberOfCards; h++)
        {
            discardPile.discardPile.Add(cards[0]);
            cards.Remove(cards[0]);
        }
        if(deck.numberOfCards<5)
        {
            discardPile.ShuffleDiscard();
            deck.DrawDiscard();
        }
        deck.DrawHand();
        endRound = false;
    }
}
