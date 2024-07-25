using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    public UnityEvent OnCollected;

    public TriggerEventUnit collect;

    public Material NormalMaterial;
    public Material HighlightMaterial;



    //_____________________________________________

    void OnTriggerEnter(Collider other)
    {


    }
    public void Collect()
    {
        OnCollected.Invoke();


        
    }

    private void Start()
    {
        
    }


}