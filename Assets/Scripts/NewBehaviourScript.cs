using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{

    public int items;
    public bool finalemode;
    public Text itemCount;
    private AudioSource allCollected;
    public AudioClip collected;
    // Start is called before the first frame update
    void Start()
    {
        this.allCollected = base.GetComponent<AudioSource>();
        allCollected = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateItemCount()
    {
        this.itemCount.text = this.items.ToString() + "/7";
        if (this.items == 7)
        {
            this.ActivateFinaleMode();
        }
    }
    public void CollectItem()
    {
        this.items++;
        this.UpdateItemCount();

    }

    public void ActivateFinaleMode()
    {
        this.finalemode = true;
        this.allCollected.PlayOneShot(this.collected, 1f);



    }
}
