using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Action", menuName = "Card/Action")]
public class Action : ScriptableObject
{
    public new string name;
    [TextArea]
    public string description;

    public Sprite artwork;

    public int Cost;
}
