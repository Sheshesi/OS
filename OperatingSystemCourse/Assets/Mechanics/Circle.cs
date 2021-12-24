using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{

    private PhotonView view;

    private Rigidbody2D rb;

    private void Awake()
    {
        view = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.MovePosition(gameObject.transform.position);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GatesTwo")
        {
            CircleController.Instance.pSP++;
            CircleController.Instance.pointSP.text = CircleController.Instance.pSP.ToString();
            gameObject.transform.position = new Vector2(0, 0);
            rb.Sleep();
        }

        if (collision.tag == "GatesOne")
        {
            CircleController.Instance.pFP++;
            CircleController.Instance.pointFP.text = CircleController.Instance.pFP.ToString();
            gameObject.transform.position = new Vector2(0, 0);
            rb.Sleep();
        }
    }
}
