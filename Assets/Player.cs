using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public void OnTriggerEnter(Collider other)
    {
        var item  = other.GetComponent<Item>();

        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            inventory.Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            inventory.Load();
        }
    }
    private void OnApplicationQuit()
    {
        inventory.container.Clear();
    }
}
