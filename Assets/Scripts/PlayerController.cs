using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;
public class PlayerController : NetworkBehaviour
{ 
    public float speed = 5f;

    private void OnNetworkInstantiate()
    {
        if (!IsOwner)
        {
            
        }
    }

    void Update() 
    { 
        if (!IsOwner)
        {
            return;
        }

        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical"); 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
        transform.Translate(movement * speed * Time.deltaTime); 
    }

    void LateUpdate() 
    { 
        Debug.Log("Player position: " + transform.position); 
    }
}