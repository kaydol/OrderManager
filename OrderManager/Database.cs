using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManager
{
    /*
        This class implements database save\load features 
    */
    static class Database<T>
    {
        public static void SaveDialogue(T data, String filter, String defaultExt)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = filter;  
            file.DefaultExt = defaultExt;
            if (file.ShowDialog() != DialogResult.OK)
                return;

            String path;
            path = file.FileName;
            SaveToFile(path, data);
        }

        public static void LoadDialogue(ref T data, String filter)
        {
            String path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = filter;
            if (file.ShowDialog() != DialogResult.OK)
                return;
            
            path = file.FileName;
            LoadFromFile(path, ref data);
        }

        public static void LoadFromFile(String path, ref T data)
        {
            if (!File.Exists(path))
                return;
            
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                data = (T) formatter.Deserialize(stream);
            }

        }

        public static void SaveToFile(String path, T database)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, database);
            }

        }
    }


}
