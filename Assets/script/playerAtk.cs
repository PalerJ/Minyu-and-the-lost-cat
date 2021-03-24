using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAtk : MonoBehaviour
{

    private float timeAtk;
    public float startTimeAtk;

    //Animator an;

    public Transform atkPos;
    public LayerMask whatEnemy;
    public Animator playerAnim;
    public float atkRangeX;
    public float atkRangeY;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //anim();

        if (timeAtk <= 0)
        {
            
            if (Input.GetKeyDown(KeyCode.K))
            {
                playerAnim.SetTrigger("isAtk");
                Collider2D[] enemyDmg = Physics2D.OverlapBoxAll(atkPos.position, new Vector2(atkRangeX, atkRangeY),1,whatEnemy);
                for (int i = 0; i < enemyDmg.Length; i++)
                {
                    enemyDmg[i].GetComponent<enemyFollow>().takeDmg(damage);
                }
                
            }
            

            timeAtk = startTimeAtk;
        }
        else
        {
            timeAtk -= Time.deltaTime;
        }
    }

   /* void anim()
    {

        if (Input.GetKey(KeyCode.K))
        {
            an.SetBool("isAtk", true);
        }
        else
        {
            an.SetBool("isAtk", false);
        }
    }*/

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(atkPos.position, new Vector3(atkRangeX, atkRangeY, 1));
    }

    
}