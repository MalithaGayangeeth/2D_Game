using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("di", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void di()
    {
        Destroy(gameObject);
    }
}
