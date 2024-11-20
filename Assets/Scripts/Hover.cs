using System;
using UnityEngine;

public class Hover : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        this.itemPosition = base.GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        this.itemPosition.localPosition = new Vector3(0f, Mathf.Sin((float)Time.frameCount * 0.0174532924f) / 8f + 1f, 0f);
    }

    private Transform itemPosition;
}
