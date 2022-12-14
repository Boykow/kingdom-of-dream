using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   [SerializeField] private float speed;
   private float directoin;
   private bool hit;
   private float lifetime;

   private BoxCollider2D boxCollider;
   private Animator anim;
   private void Awake(){
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
   }

   private void Update() {
        if(hit) return;
        float movementSpeed = speed * Time.deltaTime * directoin;
        transform.Translate(movementSpeed, 0, 0);

        lifetime += Time.deltaTime;
        if(lifetime > 5) gameObject.SetActive(false);
   }

   private void OnTriggerEnter2D(Collider2D collision) {
        hit = true;
        boxCollider.enabled = false;
        anim.SetTrigger("explode");
   }

   public void setDirection(float _direction){
        lifetime = 0;
        directoin = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        float localScaleX = transform.localScale.x;
        if(Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
   }

   private void Deactivate(){
    gameObject.SetActive(false);
   }
}
