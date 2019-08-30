using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{

    public List<GameObject> cards;
    public int numberOfCards;
    int startingDeckSize = 20;
    int handSize = 5;
    public DiscardPile discardPile;


    void Start()
    {
        numberOfCards = cards.Count;
        numberOfCards = startingDeckSize;
        Vector3 deckPosition = this.transform.position;
        for (int i = 0; i < numberOfCards; i++)
        {
            GameObject card = Instantiate(cards[i], new Vector3(deckPosition.x, deckPosition.y + (0.2f * i), deckPosition.z), Quaternion.identity).gameObject;
            card.transform.rotation = (Quaternion.Euler(-180, 90, -90));
            card.transform.parent = this.gameObject.transform;
            cards[i] = card;
        }
        DrawHand();
    }

    // Update is called once per frame
    void Update()
    {
        numberOfCards = cards.Count;
        //if(numberOfCards==0)
        //{
        //    discardPile.ShuffleDiscard();
        //    DrawDiscard();
        //    numberOfCards = cards.Count;
        //}
    }

    public Hand hand;
    //Removes the top 5 cards from the deckand adds them to the hand(childing them to the hand object)
    public void DrawHand()
    {
        int cardCount = cards.Count; 
        for (int i = 0; i < handSize; i++)
        {
            Vector3 cardPosition = new Vector3(hand.transform.position.x + (i - 1), hand.transform.position.y, hand.transform.position.z);
            GameObject firstCard = cards[cardCount - i-1];
            firstCard.transform.position = cardPosition;
            firstCard.transform.rotation = Quaternion.Euler(0, -90, -90);
            firstCard.transform.parent = hand.gameObject.transform;
            hand.cards.Add(firstCard);
            //Destroy(cards[0].gameObject);
            cards.Remove(cards[cardCount - i-1]);
            numberOfCards--;
        }
    }

    public void DrawDiscard()
    {
        for (int i = 0; i < discardPile.cards.Count; i++)
        {
            Vector3 deckPosition = new Vector3(this.transform.position.x, this.transform.position.y + (0.2f * i), this.transform.position.z);
            GameObject firstCard = discardPile.cards[i];
            firstCard.transform.position = deckPosition;
            firstCard.transform.rotation = Quaternion.Euler(-180, 90, -90);
            firstCard.transform.parent = this.gameObject.transform;
            cards.Add(firstCard);
            //Destroy(discardPile.cards[0]);
            numberOfCards++;
        }
    discardPile.cards.Clear();
    }
}
