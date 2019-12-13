using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    [SerializeField] private List<Item_SO> ItemsList = new List<Item_SO>();

    public List<Item_SO> ItemsList_ => ItemsList;
}
