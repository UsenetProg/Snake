using TMPro;
using UnityEngine;

namespace Assets._Project.Scripts
{
    public class LevelNumberText : MonoBehaviour
    {
        public TextMeshPro Text;
        public Game game;
        void Start()
        {
            Text.text = "Level" + (game.LevelIndex + 1).ToString();
        }
    }
}