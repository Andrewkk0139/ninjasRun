using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public ParticleSystem Pickup;

// will activate when object enter a collision zone 
// aka entering a box colider


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin")){
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
            // can use tags to spesify the collision, 
            // if multiple things have collisions
        }
        Debug.Log("Trigger Enter");
    }
    void Start()
    {
       
    }

    
}
