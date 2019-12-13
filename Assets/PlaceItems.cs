using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItems : MonoBehaviour
{
    public GameObject canvas;
    public ItemList IL;
    public GameObject objectTo;
    ShowItem showitem;
    
    void Awake()
    {
        for(int i = 0; i < IL.ItemsList_.Count; i++)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            GameObject NewShelf = Instantiate(objectTo, transform .position, Quaternion.identity);
            NewShelf.transform.parent = canvas.transform;
            NewShelf.transform.localScale = new Vector3(1, 1, 1);
            showitem = NewShelf.GetComponent<ShowItem>();
            showitem.PID = i;
        }
    }
}
