using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowItem : MonoBehaviour
{
    public ItemList list;
    [SerializeField] private Text Buttontext;
    public int PID;
    private void Start()
    {
        Buttontext.text = list.ItemsList_[PID].Item_name + " " + list.ItemsList_[PID].Price + "грн";
    }
}
