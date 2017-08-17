
using UnityEngine;

public class weight : MonoBehaviour
{
    public LevelManager l;
    private float distanceChain = -0.6f;
    public void WeightConnector(Rigidbody2D endRope)
    {
        HingeJoint2D join =  gameObject.AddComponent<HingeJoint2D>();
        join.autoConfigureConnectedAnchor = false;
        join.connectedBody = endRope;
        join.anchor = Vector2.zero;
        join.connectedAnchor = new Vector2(0f, distanceChain);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Hat")
        {
            Destroy(gameObject);
            LoadScene();
        }
        
    }
    void LoadScene()
    {
        l.LoadScene();
    }
}
        
       
