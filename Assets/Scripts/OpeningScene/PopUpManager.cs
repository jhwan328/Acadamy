using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public delegate void PopUpConfirmFunc();
    
    public void PopUpConfirm(PopUpConfirmFunc func)
    {
        func?.Invoke();
    }

    

}
