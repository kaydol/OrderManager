using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace OrderManager
{
    /*
        This class implements database save\load features 
    */
    static class Database
    {
        public static void SaveDialogue<T>(T data, String filter, String defaultExt)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = filter;
            file.InitialDirectory = Application.StartupPath;
            file.DefaultExt = defaultExt;
            if (file.ShowDialog() != DialogResult.OK)
                return;

            String path;
            path = file.FileName;
            SaveToFile<T>(path, data);
        }

        public static void LoadDialogue<T>(ref T data, String filter)
        {
            String path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = filter;
            file.InitialDirectory = Application.StartupPath;
            if (file.ShowDialog() != DialogResult.OK)
                return;
            
            path = file.FileName;
            LoadFromFile(path, ref data);
        }

        public static void LoadFromFile<T>(String path, ref T data)
        {
            if (!File.Exists(path))
                return;
            
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                data = (T) formatter.Deserialize(stream);
            }

        }

        public static void SaveToFile<T>(String path, T database)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, database);
            }

        }
    }

    [Serializable]
    public abstract class Data<T> {
        List<T> data = new List<T>();
        public List<T> Get()
        {
            return data;
        }
        public void Add(T c)
        {
            data.Add(c);
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < data.Count) data.RemoveAt(index);
        }
    }

    [Serializable]
    public class CustomerData : Data<Customer>
    {
        
    }

    [Serializable]
    public class AssortmentData : Data<Item>
    {
        
    }
}
