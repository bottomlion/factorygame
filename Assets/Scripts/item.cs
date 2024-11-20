using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class item : MonoBehaviour
{
    // Token: 0x06000075 RID: 117 RVA: 0x0000503C File Offset: 0x0000343C
    private void Start()
    {
    }

    // Token: 0x06000076 RID: 118 RVA: 0x00005040 File Offset: 0x00003440
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit) && (raycastHit.transform.tag == "Item" & Vector3.Distance(this.player.position, base.transform.position) < this.distance))
            {
                base.gameObject.SetActive(false);
                this.gc.CollectItem();
              //  this.learningGame.SetActive(true);
            }
        }
    }

    // Token: 0x040000CF RID: 207
    public float distance;
     
    // Token: 0x040000D0 RID: 208
    public NewBehaviourScript gc;

    // Token: 0x040000D1 RID: 209
    public Transform player;

    // Token: 0x040000D2 RID: 210
    //public GameObject learningGame;
}
