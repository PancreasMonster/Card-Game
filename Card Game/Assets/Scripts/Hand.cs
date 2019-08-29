using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public int numberOfCards;
    public List<GameObject> cards;
    bool endRound = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numberOfCards = cards.Count;
        if (Input.GetKeyDown(KeyCode.R) && endRound == false)
        {
            RoundEnd();
            endRound = true;
        }
    }

    public DiscardPile discardPile;
    void RoundEnd()
    {
        for (int h = 0; h < numberOfCards; h++)
        {
            discardPile.discardPile.Add(cards[0]);
            DestroyImmediate(cards[0], true);
            cards.Remove(cards[0]);
        }
        endRound = false;
    }
}
