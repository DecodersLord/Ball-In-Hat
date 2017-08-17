using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ropeComponent : MonoBehaviour {

    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public weight weight;

    public int links;

    static int i = 0;
    void Start () {
        if(i == 0)
        {
            links = Random.Range(2,7);
            i++;
        }
        else
        {
            links = Random.Range(7, 15);
        }
        
        GenerateRope();
        
     
}
	
    void GenerateRope()
    {
        Rigidbody2D prevHook = hook;
        for(int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = prevHook;

            if(i < links - 1)
            {
                prevHook = link.GetComponent<Rigidbody2D>();
            }else
            {
                weight.WeightConnector(link.GetComponent<Rigidbody2D>());
            }
            
        }
    }
	
}
