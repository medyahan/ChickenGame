using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speaker : MonoBehaviour
{

    public GameObject tavuk;
    public GameObject hoparlör;

    void Start()
    {
        
    }

    /*void Update()
    {   
            if(Input.GetMouseButton(0))
            {

                if (this.tavuk.transform.position.y < 6.1f && this.tavuk.transform.position.y > -6.2f && this.tavuk.transform.position.x < 3.0f && this.tavuk.transform.position.x > -3.0f)
                {
                    /*Vector3 mesafe = ((hoparlör.transform.forward * 4.0f) / Vector3.Distance(tavuk.transform.position, hoparlör.transform.position));
                    Debug.Log(mesafe);
                    tavuk.transform.position += ((hoparlör.transform.forward * 4.0f) / Vector3.Distance(tavuk.transform.position, hoparlör.transform.position));*/
    //tavuk.transform.position +=  hoparlör.transform.forward * /*new Vector3(-1.0f, 0f, 0f) */ Time.deltaTime * 5; 

    //tavuk.transform.position = this.tavuk.transform.position;
    /*              
                      this.tavuk.transform.position += ((hoparlör.transform.forward ) / Vector3.Distance(this.tavuk.transform.position, hoparlör.transform.position) * Time.deltaTime * 2);
                  }

                  else
                  {
                      Application.LoadLevel("Failed");
                  }
              }
     }*/

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == this.gameObject)
                {
                    if (this.tavuk.transform.position.y < 6.2f && this.tavuk.transform.position.y > -6.2f && this.tavuk.transform.position.x < 3.2f && this.tavuk.transform.position.x > -3.2f)
                    {
                        tavuk.transform.position += (hoparlör.transform.forward) / Vector3.Distance(10*(this.tavuk.transform.position), (hoparlör.transform.position)*10) * Time.deltaTime * 100;
                        //Debug.Log("aaaa");
                    }

                    else
                    {
                        Application.LoadLevel("Failed");
                    }


                }
            }
        }
    }

    private void OnCollisionEnter(Collision obj)
    {
        //Debug.Log("hoparlör carpisma gerceklesti..");
        Application.LoadLevel("Failed");
        
    }

    /*public void pointerDown()
    {
        Debug.Log("dsdsda");
    }*/
}

    

    /*private void OnMouseDown()
   {

        Vector3 mesafe = ((hoparlör.transform.forward * 4.0f) / Vector3.Distance(tavuk.transform.position, hoparlör.transform.position));
        Debug.Log(mesafe);

        tavuk.transform.position += ((hoparlör.transform.forward * 4.0f) / Vector3.Distance(tavuk.transform.position, hoparlör.transform.position));

        Vector3 kontrol = this.tavuk.transform.position + mesafe;



        /*while (this.tavuk.transform.position != kontrol)
        {
            tavuk.transform.localPosition += mesafe * Time.deltaTime * 0.1f;

    } */



