using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingProjectile : MonoBehaviour
{
    public GameObject player;
    public BoundsCheck bndCheck;
    public Rigidbody rigid;

    private void Awake() {
        rigid = GetComponent<Rigidbody>();
        player = GameObject.Find("_Hero");
    }
    void Update()
    {
        if (bndCheck.LocIs(BoundsCheck.eScreenLocs.offUp))
        {
            Destroy(gameObject);
        }

        var step =  vel.magnitude * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);

    }

    public Vector3 vel
    {
        get { return rigid.velocity; }
        set { rigid.velocity = value; }
    }
    
}
