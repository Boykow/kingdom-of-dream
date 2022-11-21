using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Камера комнат
    [SerializeField] private float speed;
    private float currentPostX;
    private Vector3 velocity = Vector3.zero;
    //Слідкувати за гравцем
    [SerializeField]private Transform player;
    [SerializeField]private float aheadDistance;
    [SerializeField]private float cameraSpeed;
    private float lookAhead;

    private void Update() {
        //Камера комнат
         //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPostX, transform.position.y, transform.position.z), ref velocity, speed);
         
         //Слідкувати за гравцем
         transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
         lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }

    public void MoveToNewRoom(Transform _newRoom){
        currentPostX = _newRoom.position.x;
    }
}
