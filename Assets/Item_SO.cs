using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "продукт", menuName = "Item", order = 51)]
public class Item_SO : ScriptableObject
{
    [SerializeField] private string item_name;
    [SerializeField] private int price;
    [SerializeField] private string manufacturer;
    [SerializeField] private string expiration_date;

    public string Item_name => item_name;
    public int Price => price;
    public string Manufacturer => manufacturer;
    public string Expiration_date => expiration_date;
}
