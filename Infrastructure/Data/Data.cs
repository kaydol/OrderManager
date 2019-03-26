using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager.Domain.Core;

namespace OrderManager.Infrastructure.Data
{
    [Serializable]
    public abstract class Data<T>
    {
        public List<T> data = new List<T>();

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

        public void SaveDialogue(String filter, String defaultExt)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = filter;
            file.InitialDirectory = Application.StartupPath;
            file.DefaultExt = defaultExt;
            if (file.ShowDialog() != DialogResult.OK)
                return;

            String path;
            path = file.FileName;
            SaveToFile(path);
        }

        public void LoadDialogue(String filter)
        {
            String path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = filter;
            file.InitialDirectory = Application.StartupPath;
            if (file.ShowDialog() != DialogResult.OK)
                return;

            path = file.FileName;
            LoadFromFile(path);
        }

        public void LoadFromFile(String path)
        {
            if (!File.Exists(path))
                return;

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                data = (List<T>)formatter.Deserialize(stream);
            }

        }

        public void SaveToFile(String path)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, data);
            }

        }
    }

    public class CustomerData : Data<Customer> { }
    public class AssortmentData : Data<Item> { }

}
