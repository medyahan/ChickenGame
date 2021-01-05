using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision obj)
    {
        Debug.Log("carpisma gerceklesti..");
        Destroy(obj.gameObject);
        Application.LoadLevel("Won");
        // kazandınız sahnesine gitmeli
    }
}
