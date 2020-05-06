using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] int damage = 25;
    [SerializeField] LayerMask ignoreLayer;
    [SerializeField] public GameObject Muzzle;
    public Animator _animator;

    private void Start()
    {
        Muzzle.SetActive(false);
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
       if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void sound()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SoundManager.sndMan.PlayGunSound();

        }
=======
       if (Input.GetButtonDown("Fire1"))
        { 
            Shoot();          
        } 
>>>>>>> a9878a1f2ad346eb1aa671a147ecfba36e882f04
    }

private void Shoot()
    {

<<<<<<< HEAD
        sound();
=======
>>>>>>> a9878a1f2ad346eb1aa671a147ecfba36e882f04
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range, ignoreLayer))
        {
            Debug.Log("Kuole saatanan " + hit.transform.name);
            Poll targetPol = hit.transform.GetComponent<Poll>();
            if (targetPol)
                targetPol.Hit();
            //TODO: add some hit effect for visual players
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            // call a method on EnemyHealth that decreases the enemy's health
            Debug.Log("Damaging this soB");
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }
}
