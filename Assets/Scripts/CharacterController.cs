using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterController : MonoBehaviour
{
    public int lifePlayer = 1;
    public string namePlayer = "Mr. Blue";
    public float speedPlayer = 1f;
    // public GameObject swordPlayer;
    public Vector3 initPosition = new Vector3(-2.5f, 1f, 4.5f);
    //public Vector3 swordPosition = new Vector3(0, 0, 0.3f);
    public float cameraAxisX = -90f;
    private bool isGrounded = true;

    //
    private KeyInventory mgInventory;

    public event Action onDeath;
    public event Action onGhost;
    public event Action onFlowers;


    //
    // Start is called before the first frame update
    void Start()
    {
        mgInventory = GetComponent<KeyInventory>();
        PlayerEvents.onDeath += GameOverCharacterControllerOFF;
        PlayerEvents.onGhost += TouchGhost;
        PlayerEvents.onFlowers += TouchFlowers;

    }

    private  void GameOverCharacterControllerOFF()
    {
        GameObject.Find("MainCharacter").GetComponent<CharacterController>().enabled = false;
        StartCoroutine(DeactivateMoves());
    }
    private void TouchGhost()
    {
        speedPlayer = 1f;
    }

    private void TouchFlowers()
    {
        speedPlayer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        RotatePlayer();
        //swordPlayer.transform.position = transform.position + swordPosition;
        
        if (Input.GetKeyUp(KeyCode.K))
        {
            UseItem();
        }

    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");

        if (ejeHorizontal != 0 || ejeVertical != 0)
        {
            transform.Translate(speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
        }



    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angulo = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angulo;
       ;
    }

    //
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            lifePlayer--;
            Destroy(collision.gameObject);
            if(lifePlayer == 0)
            {
                PlayerEvents.OnDeath();
                Debug.Log("Game Over");
            }
        }

        

    }
    //

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            isGrounded = true;
        }
        if (other.gameObject.CompareTag("Key"))
        {
            //Destroy(other.gameObject);
            GameObject key = other.gameObject;
            key.SetActive(false);
            mgInventory.AddInventoryOne(key);
        }
        if (other.gameObject.CompareTag("Key"))
        {
            GameObject key = other.gameObject;
            key.SetActive(false);
         
            mgInventory.AddInventoryThree(key.name, key);
            mgInventory.SeeInventoryThree();
            mgInventory.CountKey(key);
        }

        if (other.gameObject.CompareTag("Ghost"))
        {

            PlayerEvents.OnGhost();
            speedPlayer = 1f;

        }

        if (other.gameObject.CompareTag("Flower"))
        {
            PlayerEvents.OnFlowers();
            speedPlayer = 2f;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }

    private void UseItem()
    {
        GameObject key = mgInventory.GetInventoryOne();
        key.SetActive(true);
        key.transform.position = transform.position + new Vector3(1f, 1f, 1f);
    }


    IEnumerator DeactivateMoves()
    {
      
        yield return new WaitForSeconds(2f);
        GameObject.Find("MainCharacter").GetComponent<CharacterController>().enabled = false;
        //GameObject.Find("MainCharacter").GetComponent<Animator>().enabled = false;
        GameObject.Find("MainCharacter").GetComponent<AnimationController>().enabled = false;


    }



}
