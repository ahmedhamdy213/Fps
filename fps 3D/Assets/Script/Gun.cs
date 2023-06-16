
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int damage = 10;
    public float Range = 100f;
    public float ImpactForce = 30f;
    public float fireRate = 15f;
    public Camera FpsCam;
    public ParticleSystem Flash;
    private float NextTimetoFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= NextTimetoFire)
        {
            NextTimetoFire= Time.time * 1f/fireRate;
            Shoot();
        }
    }
    
    void Shoot()
    {
        Flash.Play();
        RaycastHit hit;
       if( Physics.Raycast(FpsCam.transform.position,FpsCam.transform.forward, out hit, Range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            
           if( hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(hit.normal* ImpactForce);

            }
        }

    }
   
}
