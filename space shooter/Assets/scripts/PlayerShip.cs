using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerShip : MonoBehaviour
{
    public float speed = 60.0f;
    public float horizontalInput;
    public GameObject projetilePrefeb;
    public float health=100f;
    public Image bar;
    public GameObject overmenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = health / 100;
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *horizontalInput* Time.deltaTime * speed);
        if(transform.position.x < -18)
        {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 38.3f)
        {
            transform.position = new Vector3(38.3f, transform.position.y, transform.position.z);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetilePrefeb, transform.position, projetilePrefeb.transform.rotation);
        }
        if (health < 0)
        {
            Debug.Log("gameover");
            overmenu.SetActive(true);
            Time.timeScale = 0;
        }

        
    }

    public void fire()
    {
        Instantiate(projetilePrefeb, transform.position, projetilePrefeb.transform.rotation);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            health = health - 20;
        }
        else if (other.gameObject.tag == "Health")
        {
            health = 100;
        }
    }

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
