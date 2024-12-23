using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [Header("Storage Settings")]
    public List<CollectableItem> items = new List<CollectableItem>();

    public void AddItem(CollectableItem item)
    {
        items.Add(item);
        Debug.Log($"Item {item.itemName} added to storage. Total items: {items.Count}");
    }

    public void RemoveItem(CollectableItem item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log($"Item {item.itemName} removed from storage. Remaining items: {items.Count}");
        }
        else
        {
            Debug.Log("Item not found in storage.");
        }
    }
}
