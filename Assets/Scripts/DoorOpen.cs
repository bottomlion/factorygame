using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

namespace UIToolkitDemo
{

    [RequireComponent(typeof(AudioSource))]
    public class DoorOpen: MonoBehaviour
    {

        AudioSource audioSource;
        public AudioClip doorOpen;
        private AudioSource myAudio;
        public MeshRenderer door;
        public MeshCollider trigger;
        public GameObject obstacle;
        public MeshCollider barrier;
        public bool alreadyPlayed = false;
        private bool bDoorOpen;
        private bool bDoorClosed;
        public Material closed;
        public Material open;
        Renderer rend;
        float timer = 3f;

        private void Start()
        {
            this.myAudio = base.GetComponent<AudioSource>();
            myAudio = GetComponent<AudioSource>();
        }


        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Door opens now.");
            this.bDoorOpen = true;

            if (other.tag == "Player" && !myAudio.isPlaying) ;
            {
                this.myAudio.PlayOneShot(this.doorOpen, 1f);
                this.door.sharedMaterial = this.open;
                // this.bDoorOpen = true;

            }


        }

        private void OnTriggerExit(Collider other)
        {


            StartCoroutine(Closeit());
            // if (this.timer <= 0f & this.bDoorOpen) 
            {
                //    this.bDoorOpen = false;



            }

            IEnumerator Closeit()
            {

                yield return new WaitForSeconds(3);
                this.door.sharedMaterial = this.closed;
                this.bDoorOpen = false;
                this.bDoorClosed = true;
            }
        }

    }

}
