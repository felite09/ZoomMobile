using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    [SerializeField] int frequencia;
    Touch toq;
    Touch[] toqs;
    float tempo;
    int delta, aux; 

    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        aux = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        aux = Mathf.FloorToInt(tempo);
        if (aux > delta)
        {

            delta = aux + frequencia;
            toqs = Input.touches;

            foreach (Touch i in toqs)
            {
                Debug.Log("ID:" + i.fingerId + "(" + i.position.x + "," + toq.position.y + ")");
            }
        }

        /*if (Input.touchCount > 0)
        {
            toq = Input.GetTouch(0);
            
            Debug.Log("(" + toq.position.x + "," + toq.position.y + ")");
            




        }
        */
    }




}
