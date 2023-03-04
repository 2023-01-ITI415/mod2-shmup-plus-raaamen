using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_5 : Enemy
{
    public GameObject projectile;

    public float projectileSpawnTimer;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    public override void Move()
    {
        base.Move();
    }

    IEnumerator ShootProjectile(){
        while (true)
        {
            yield return new WaitForSeconds(projectileSpawnTimer);
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}
