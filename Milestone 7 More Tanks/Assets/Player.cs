using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int healthPoints = 100;

    public GameObject turret;
    public GameObject bullet;

    public void TakeDamage(int damage)
    {
        healthPoints -= 10;
        Debug.Log("You took damage! " + healthPoints + "/100");
    }

    void Fire()
    {
        GameObject b = Instantiate(bullet, turret.transform.position, turret.transform.rotation);
        b.GetComponent<Rigidbody>().AddForce(turret.transform.forward * 500);
    }
    public void StopFiring()
    {
        CancelInvoke("Fire");
    }
    public void StartFiring()
    {
        InvokeRepeating("Fire", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartFiring();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke();
        }

        if (this.healthPoints <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
