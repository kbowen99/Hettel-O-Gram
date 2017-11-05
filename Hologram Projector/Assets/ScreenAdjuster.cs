using UnityEngine;
using System.Collections;

public class ScreenAdjuster : MonoBehaviour {

    float adj = 0.01f;

	// Use this for initialization
	void Start () {
        int square = Screen.height;
        Screen.SetResolution(square, square, true);
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Camera cam = GameObject.Find("Camera North").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x, cam.rect.y-adj, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera South").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x, cam.rect.y+adj, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera West").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x+adj, cam.rect.y, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera East").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x-adj, cam.rect.y, cam.rect.width, cam.rect.height);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Camera cam = GameObject.Find("Camera North").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x, cam.rect.y + adj, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera South").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x, cam.rect.y - adj, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera West").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x - adj, cam.rect.y, cam.rect.width, cam.rect.height);
            cam = GameObject.Find("Camera East").GetComponent<Camera>();
            cam.rect = new Rect(cam.rect.x + adj, cam.rect.y, cam.rect.width, cam.rect.height);
        }
    }
}
