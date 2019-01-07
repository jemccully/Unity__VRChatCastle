using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableToggler : MonoBehaviour
{
	public void ToggleEnable()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
