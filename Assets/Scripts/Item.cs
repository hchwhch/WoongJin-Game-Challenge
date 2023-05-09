using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemId
{
    sword
}

public enum ItemGrade
{
    normal,
    rare,
    epic,
    legendary
}

public class Item : MonoBehaviour
{
    public string name;
    public string discription;
    public ItemGrade grade;
    public ItemId id;
}
