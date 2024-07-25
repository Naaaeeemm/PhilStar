using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Quest : MonoBehaviour
{
    private QuestScreen QuestScreen;



    public string QuestObjective;

    public bool Compleated;
    public UnityEvent OnCompleated; 

    // Start is called before the first frame update
    void Start()
    {
        
        QuestScreen = FindFirstObjectByType<QuestScreen>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartQuest()
    {
        if (Compleated)
            return;

        QuestScreen.ShowQuest(this);
    }

    public void EndQuest()
    {
        if (Compleated)
            return;

        QuestScreen.FinishQuest(this);
        Compleated = true;
        OnCompleated.Invoke();
    }
}
