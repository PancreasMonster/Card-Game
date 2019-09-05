using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Project", menuName = "Card/Project")]
public class Project : ScriptableObject
{
    public new string name;
    public string objective;
    public string reward;

    public Sprite artwork;

    public int Cost;
}