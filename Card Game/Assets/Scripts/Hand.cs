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
            StartCoroutine(RoundEnd());
            //RoundEnd();
        }
    }

    public DiscardPile discardPile;
    public Deck deck;
    GameObject cardToDestroy;

    IEnumerator Waiter(GameObject card)
    {
        yield return new WaitUntil(() => card.GetComponent<CardMovement>().moving == false);
    }

    public IEnumerator RoundEnd()
    {
        numberOfCards = cards.Count;
        float discardSize = discardPile.cards.Count;
        for (int i = 0; i < numberOfCards; i++)
        {
            Vector3 discardPosition = new Vector3(discardPile.transform.position.x, discardPile.transform.position.y, discardPile.transform.position.z);
            GameObject currentCard = cards[0];
            currentCard.GetComponent<CardMovement>().target = discardPosition;
            currentCard.GetComponent<CardMovement>().moving = true;

            currentCard.GetComponent<CardMovement>().hand = false;
            currentCard.GetComponent<CardRotation>().hand = false;
            while (currentCard.GetComponent<CardMovement>().moving)
            {
                yield return new WaitForEndOfFrame();
            }

            //currentCard.transform.rotation = Quaternion.Euler(-180, 90, -90);
            currentCard.transform.parent = discardPile.gameObject.transform;


            discardPile.cards.Add(currentCard);
            cards.Remove(cards[0]);

        }
        if (deck.numberOfCards<5)
        {
            
            discardPile.ShuffleDiscard();
            deck.StartCoroutine(deck.DrawDiscard());
        }
        deck.StartCoroutine(deck.DrawHand());
        endRound = false;
    }


}
