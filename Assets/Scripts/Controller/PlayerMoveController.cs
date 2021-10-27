using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    float _speed = 5.0f;

    Vector3 dir = new Vector3();

    Animator anim;

    public GameObject player;
    public GameObject ATM;
    public SceneChangeManager scm;
    
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        ATM = GameObject.Find("ATMPad");
    }

    private void FixedUpdate()
    {
        KeyInput();
        Move();
    }

    void Init()
    {
        player = GameObject.Find("Player");
        ATM = GameObject.Find("ATMPad");
        anim = player.GetComponent<Animator>();
        scm = new SceneChangeManager();
    }

    void KeyInput()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        if(dir.x == 0.0f && dir.y == 0.0f)
        {
            anim.SetBool("IsMoving", false);
        }
        else
        {
            anim.SetBool("IsMoving", true);
            if(dir.y > 0.0f)
            {
                anim.SetInteger("Direction", 0);
            }
            else if (dir.x > 0.0f)
            {
                anim.SetInteger("Direction", 1);
            }
            else if (dir.y < 0.0f)
            {
                anim.SetInteger("Direction", 2);
            }
            else if (dir.x < 0.0f)
            {
                anim.SetInteger("Direction", 3);
            }
        }

        player.transform.position += _speed * Time.deltaTime * new Vector3(dir.x, dir.y, 0.0f).normalized;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.name);

        switch (collision.transform.name)
        {
            case "BankPortal":
                scm.SceneChange(SceneChangeManager.Scenes.BankScene);
                break;
            case "HomePortal1":
                scm.SceneChange(SceneChangeManager.Scenes.HomeScene);
                break;
            case "HomePortal2":
                break;
            default:
                Debug.Log("TriggerNotFound");
                break;
        }
    }
}
