using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int hits = 0;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
             hits++;
        }
        Debug.Log("You've bumped into a thing this many times: " + hits);        
        
    }   
}
