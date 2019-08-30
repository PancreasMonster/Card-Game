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
    GameObject cardToDestroy;

    public void RoundEnd()
    {
        numberOfCards = cards.Count;
        float discardSize = discardPile.cards.Count;
        for (int i = 0; i < numberOfCards; i++)
        {
            Vector3 discardPosition = new Vector3(discardPile.transform.position.x, discardPile.transform.position.y + (0.2f*(i + discardSize)), discardPile.transform.position.z);
            GameObject firstCard = cards[0];
            firstCard.transform.position = discardPosition;
            firstCard.transform.rotation = Quaternion.Euler(-180, 90, -90);
            firstCard.transform.parent = discardPile.gameObject.transform;
            discardPile.cards.Add(firstCard);
            //Destroy(cards[0].gameObject);
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
