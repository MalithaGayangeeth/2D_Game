using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float speed;
    public float position;
   // public GameObject Score;
    public float damageAmount;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
      //  Score = GameObject.FindGameObjectWithTag("score");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < position)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

       
        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            
        }
    }
}
