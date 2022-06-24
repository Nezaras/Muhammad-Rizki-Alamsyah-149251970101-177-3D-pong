using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleController : MonoBehaviour
{
    public int speed;
    private Rigidbody rig;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;

    public bool isP1;
    public bool isP2;
    public bool isP3;
    public bool isP4;
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }
        return Vector3.zero;
    }
    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }

    /* public void destroyPlayer()
    {
        if (isP1)
        {
            gameObject.SetActive(false);

        }
        if (isP2)
        {
            gameObject.SetActive(false);
        }
        if (isP3)
        {
            gameObject.SetActive(false);
        }
        if (isP4)
        {
            gameObject.SetActive(false);
        }
    }*/
}
