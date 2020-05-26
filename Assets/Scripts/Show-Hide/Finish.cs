using UnityEngine;

public class Finish : MonoBehaviour
{
   
    public GameObject Finished;
    public GameObject Finished2;


    void OnMouseDown()
    {
      
            Finished.SetActive(true);

        Finished2.SetActive(true);

    }
}
