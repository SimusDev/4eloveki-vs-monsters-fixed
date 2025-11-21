using TMPro;
using UnityEngine;

namespace Interface
{
    public class MainMenu : MonoBehaviour
    {

        [SerializeField] private TextMeshProUGUI textArea;

        private Network network;

        public void HostGame()
        {
            network = Network.singleton;
            network.StartHost();
        }

        public void ConnectToGame()
        {
            network = Network.singleton;
            network.networkAddress = textArea.text;
            network.StartClient();
        }

    }
}
