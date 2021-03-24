using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float monSpeed;
    public float monHp;
    private Transform target;
    

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, monSpeed * Time.deltaTime);
        //transform.Translate(Vector2.left * monSpeed * Time.deltaTime);

        if (monHp <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    public void takeDmg(int damage)
    {
        monHp -= damage;
        Debug.Log("damage taken");
    }

    /*void monFlip()
    {
        MonfacingL = !MonfacingL;
        Vector3 monScaler = transform.localScale;
        monScaler.x *= -1;
        transform.localScale = monScaler;
    }*/
}
