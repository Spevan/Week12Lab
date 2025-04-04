using UnityEngine;
public class DataLogger : MonoBehaviour 
{ 
    public PlayerController player; 
    void Update() 
    { 
        LogPlayerData(); 
    } 
    
    void LogPlayerData() 
    { 
        Debug.Log("Player Position: " + player.transform.position); 
        Debug.Log("Player Input: " + Input.GetAxis("Horizontal") + ", " + Input.GetAxis("Vertical")); 
    } 
}