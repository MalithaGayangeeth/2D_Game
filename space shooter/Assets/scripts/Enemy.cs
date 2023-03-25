using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float position;
    public GameObject Score;
    public float damageAmount;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("score");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (damageAmount <= 0)
        {
            Score.GetComponent<Score>().score = Score.GetComponent<Score>().score + 10;
            Destroy(gameObject);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            
        }
        if(transform.position.z<position)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "laser")
        {
            damageAmount = damageAmount - 5;
            


        }
        if (other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
        }
    }
}
