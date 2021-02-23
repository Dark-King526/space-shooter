using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
    private float speed = 5;
    void Start() {
        Destroy(this.gameObject,5f);
    }
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Hero>().hp--;
            other.GetComponent<Hero>().UpdatePlayerState();
        }
     }
}
