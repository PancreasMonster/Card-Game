using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    
    public int numberOfCards;
    public List<GameObject> cards;
    int startingDeckSize = 10;
    int handSize = 5;

    void Start()
    {
        numberOfCards = startingDeckSize;
        DrawHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Hand hand;
    //Removes the top 5 cards from the deckand adds them to the hand(childing them to the hand object)
    void DrawHand()
    {
        for (int c = 0; c < handSize; c++)
        {
            GameObject firstCard = Instantiate(cards[0], this.transform.position, Quaternion.identity).gameObject;
            firstCard.transform.parent = hand.gameObject.transform;
            hand.cards.Add(cards[0]);
            cards.Remove(cards[0]);
            numberOfCards--;
        }
    }
}
