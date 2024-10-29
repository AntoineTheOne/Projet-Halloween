using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField] private int time = 120;
    [SerializeField] private bool CountDownOn = true;

	void Start() {
		StartCoroutine(timer());
	}

	IEnumerator timer () {
		
		while(time > 0) {
			
			yield return new WaitForSeconds (1f);
            time--;
			GetComponent<TMP_Text>().text = time.ToString();
		}
	}
}
