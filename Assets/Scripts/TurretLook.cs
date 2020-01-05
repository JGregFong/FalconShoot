using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLook : MonoBehaviour
{
    //public Transform Target;
    public float RotationSpeed;
    public float boltSpeed = 20;
    public float YLookOffset = 30f;
    private Quaternion lookRotation;
    private Vector3 targetDirection;
    GameObject Emitter;
    private Camera Cam;
    GameObject Reticle;
    public GameObject bolt;
    private float nextTimeToFire = 0f;
    public float fireRate = 1.3f;
    private AudioSource mAudioSrc;

    private void Start()
    {
        Cam = Camera.main;
        Reticle = GameObject.Find("CrossHair");
        Emitter = GameObject.Find("TurretOutput");
        targetDirection = new Vector3();
        Cursor.visible = false;
        mAudioSrc = GetComponent<AudioSource>();
        
    }


    // Update is called once per frame
    void Update()
    {
        Reticle.transform.position = Input.mousePosition;
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            //Instantiate
            nextTimeToFire = Time.time + 1f/fireRate;
            FireBolt();
            
        }

    }

    private void FireBolt()
    {
        mAudioSrc.Play();
        GameObject blasterBolt = Instantiate(bolt, Emitter.transform.position, Emitter.transform.rotation);
        Rigidbody rb = blasterBolt.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * boltSpeed, ForceMode.VelocityChange);
    }

    private void OnGUI()
    {
        Vector2 mousePosition = new Vector2();
        Event currentEvent = Event.current;

        mousePosition.x = currentEvent.mousePosition.x;
        mousePosition.y = Cam.pixelHeight-currentEvent.mousePosition.y;
        //Y-Position is offset
        targetDirection = Cam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y-YLookOffset, 1000));
        //lookRotation = Quaternion.LookRotation(new Vector3(0, 0, 20));
        GUILayout.BeginArea(new Rect(10, 10, 1280, 720));
        GUILayout.EndArea();
        lookRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = lookRotation;
    }
}
