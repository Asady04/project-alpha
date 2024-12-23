using UnityEditor.SceneManagement;
using UnityEngine;

public class CollectingSystem : MonoBehaviour
{
    [Header("Storage System")]
    public Storage storage;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object has a "Collectible" tag
        if (other.CompareTag("Collectible"))
        {
            CollectableItem item = other.GetComponent<CollectableItem>();
            if (item != null)
            {
                // Add the item to storage
                storage.AddItem(item);

                // Disable the collected item
                other.gameObject.SetActive(false);
            }
        }
    }
}
