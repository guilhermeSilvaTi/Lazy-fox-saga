using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    public static void SaveGame()
    {
        Save save = new Save();

        StatesGame.SetSave(save);

        ConvertToBinarySave(save);
    }
    public static Save LoadGame()
    {
        BinaryFormatter binaryF = new BinaryFormatter();

        string path = Application.persistentDataPath;//AppData/LocalLow/Seunome
        FileStream file;

        if (File.Exists(path + "/savegame.save"))
        {
            file = File.Open(path + "/savegame.save", FileMode.Open);
            Save save = (Save)binaryF.Deserialize(file);
            file.Close();
            StatesGame.SetLoad(save);
            return save;
        }
        else
        {
            StatesGame.ResetStatics();
            SaveGame();
        }

        return null;
    }

    private static void ConvertToBinarySave(Save save)
    {
        BinaryFormatter binary = new BinaryFormatter();

        string path = Application.persistentDataPath;//AppData/LocalLow/Seunome

        FileStream file = File.Create(path + "/savegame.save");

        binary.Serialize(file, save);
        file.Close();
    }
}
