using UnityEngine;

public class MinimapCameraFollow : MonoBehaviour
{
    public Transform player; // Referensi ke pemain

    void LateUpdate()
    {
        if (player != null)
        {
            // Kamera mengikuti posisi pemain
            Vector3 newPosition = player.position;
            newPosition.y = transform.position.y; // Tetap di atas peta
            transform.position = newPosition;
        }
    }
}
