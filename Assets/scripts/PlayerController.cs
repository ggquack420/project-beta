using UnityEngine;

//ref = https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 4f;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
    }

    void Update()
    {
        
        float move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector3(move * moveSpeed, rig.velocity.y, 0f);

        if (Input.GetButtonDown("Jump")) 
       {
            rig.velocity = new Vector3(rig.velocity.x, jumpForce, 0f);
        }

    }
}
