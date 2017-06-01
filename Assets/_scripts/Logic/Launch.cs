using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launch : MonoBehaviour {

	// Use this for initialization
	void Start () {

        SceneManager.LoadScene("dontdestroy");
        AsyncOperation op = SceneManager.LoadSceneAsync("start",LoadSceneMode.Additive);

       // Interlocked.Increment(1);



	}
	
	
}
