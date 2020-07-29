using TapsellSDK;
using UnityEngine;

public class TapsellInitializer : MonoBehaviour {

  private readonly string TAPSELL_KEY = "kilkhmaqckffopkpfnacjkobgrgnidkphkcbtmbcdhiokqetigljpnnrbfbnpnhmeikjbq";

  void Start () {
    Tapsell.Initialize (TAPSELL_KEY);
  }
}