using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogScreen : MonoBehaviour
{

    private DialogItem currentItem;

    public GameObject Container;

    public TMP_Text TextBox;

    public List<GameObject> Buttons;

    public UnityEvent<bool> DialogOpen;

    


    // Start is called before the first frame update
    void Start()
    {
        EndDialog();
    }

    public void StartDialog(DialogItem item)
    {
        Container.SetActive(true);

        TextBox.text = item.Text;

        //for schleife
        for (int i = 0; i < Buttons.Count; i++)
        {
            if (i < item.Options.Count)
            {
                Buttons[i].SetActive(true);
                Buttons[i].GetComponentInChildren<TMP_Text>().text = item.Options[i].Text;
            }
            else
            {
                Buttons[i].SetActive(false);
            }
        }

        currentItem = item;

        DialogOpen.Invoke(true);


        
    }

    public void EndDialog()
    {
        Container.SetActive(false);
        DialogOpen.Invoke(false);

        
    }

    public void ChooseOption(int index)
    {
        DialogOption option = currentItem.Options[index];

       

        if (option.NextDialog != null)
        {
            StartDialog(option.NextDialog);
        }
        else
        {
            EndDialog();
        }
    }
}
