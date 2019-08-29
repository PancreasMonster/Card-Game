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

    void DrawHand()
    {
        for (int c = 0; c < handSize; c++)
        {
            GameObject firstCard = Instantiate(cards[0], this.transform.position, Quaternion.identity).gameObject;
            cards.Remove(cards[0]);
            numberOfCards--;
        }
    }
}
