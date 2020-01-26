using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Invoke("DestroyTarget", 2);
        //Destroy(this.gameObject, 2);
    }
    private void DestroyTarget()
    {
        Destroy(this.gameObject);
        GameObject.Find("GameManager").GetComponent<GameManager>().DecrementScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        GameObject.Find("GameManager").GetComponent<GameManager>().IncrementScore();
    }

}
