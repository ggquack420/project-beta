using UnityEngine;
using UnityEngine.SceneManagement;
//refh https://youtu.be/EfUCEwKmcjc?si=czW5ScdVvdd35KNU
//ref https://docs.unity3d.com/6000.2/Documentation/Manual/CollidersOverview.html
public class DeathGem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
    
        PlayerInventory Inventory = other.GetComponent<PlayerInventory>();

        if (Inventory != null)
        {
            gameObject.SetActive(false);

            SceneManager.LoadScene("death");
        }
    }
}





