using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Card/Unit")]

public class Unit : ScriptableObject
{
    public new string name;
    [TextArea]
    public string description;

    public Sprite artwork;

    public int Cost;
    public int attack;
    public int defense;
}
