using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] float slowSpeed = 1f;
    [SerializeField] float walkSpeed = 2f;
    [SerializeField] float runSpeed = 4f;
    [SerializeField] float currentSpeed = 2f;
    [SerializeField] float messageDuration = 5f;

    private float messageTimeRemaining;
    private bool isMessage = false;

    public GameObject speechObject;
    // Start is called before the first frame update
    void Start()
    {
        speechObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 ;
        if (Input.GetAxis("Fire1")>0)
        {
            currentSpeed = runSpeed;
        }
        else if (Input.GetAxis("Fire2") > 0)
        {
            currentSpeed = slowSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        float xChange = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        float yChange = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        transform.Translate(xChange, 0, 0);
        transform.Translate(0, yChange, 0);

        if (isMessage)
        {
            messageTimeRemaining -= Time.deltaTime;

            if (messageTimeRemaining < 0)
            {
                speechObject.SetActive(false);
                isMessage = false;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Wall")
        {
            createMessage("Ouch.");
        }

        if (collision.gameObject.tag == "Door")
        {
            createMessage("I don't have the key.");
        }

    }


    void createMessage(string text)
    {
        speechObject.SetActive(true);

        speechObject.GetComponentInChildren<TextMeshPro>().text = text;
        messageTimeRemaining = messageDuration;
        isMessage = true;
    }





}