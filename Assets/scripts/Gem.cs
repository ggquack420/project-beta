using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound;
    [SerializeField] private float soundVolume = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory Inventory = other.GetComponent<PlayerInventory>();

            if (Inventory != null)
            {
              
                Inventory.GemCollected();

            //ref https://docs.unity3d.com/6000.2/Documentation/Manual/AudioSource-overview.html
                if (collectSound != null)
                    AudioSource.PlayClipAtPoint(collectSound, transform.position, soundVolume);

               
                gameObject.SetActive(false);
            }
        }
    }
}




