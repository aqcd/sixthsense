using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace MoreMountains.TopDownEngine
{
    public class Bike : MonoBehaviour
    {
        private AudioSource audioSource;

        [SerializeField]
        public float speed = 5;

        [SerializeField]
        public bool isGoingLeft = false;

        [SerializeField]
        public float threshold = 5.0f;

        // Start is called before the first frame update
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
            Destroy(gameObject, 30);
        }

        // Update is called once per frame
        void Update()
        {
            float dist = Vector3.Distance(gameObject.transform.position, LevelManager.Instance.Players[0].transform.position);

            if (!WalkingStickManager.hasWalkingStick || dist > threshold) {
                Vector3 originalPosition = gameObject.transform.position;
                Vector3 deltaPosition = new Vector3((isGoingLeft ? -1 : 1) * speed * Time.deltaTime, 0, 0);
                gameObject.transform.position = originalPosition + deltaPosition;
            }
        
            if (Vector3.Distance(gameObject.transform.position, PlayerPositionManager.instance.position) < 10.0f) {
                audioSource.mute = false;
                audioSource.panStereo = (gameObject.transform.position.x - PlayerPositionManager.instance.position.x) / 10.0f;
            } else {
                audioSource.mute = true;
            }
        }
    }
}