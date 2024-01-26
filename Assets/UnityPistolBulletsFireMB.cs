using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UnityPistolBulletsFireMB : MonoBehaviour
{
    public GameObject Bullet;
    public Transform SpawnPoint;
    public float FireSpeed = 20;
    public float TimeForRemoved = 5;

    private void Start() =>
        GetComponent<XRGrabInteractable>().activated.AddListener(BulletFire);

    public void BulletFire(ActivateEventArgs Arguments)
    {
        var GameObjectCreated = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
        GameObjectCreated.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * FireSpeed;
        Destroy(GameObjectCreated, TimeForRemoved);
    }
}
