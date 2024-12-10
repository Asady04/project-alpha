using UnityEngine;

public class MinimapFollowPlayer : MonoBehaviour
{
    public Transform player; // Referensi ke pemain
    public float yOffset = 10f; // Tinggi ikon di minimap (agar berada di atas peta)

    void LateUpdate()
    {
        if (player != null)
        {
            // Ikuti posisi pemain
            Vector3 newPosition = player.position;
            newPosition.y += yOffset; // Tambahkan offset Y
            transform.position = newPosition;

            // Opsional: Ikuti arah rotasi pemain
            transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
        }
    }
}
