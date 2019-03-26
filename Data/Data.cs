using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager.Domain.Core;
using OrderManager.Domain.Interfaces;

/*
 Данный проект будет реализовывать интерфейсы, объявленные на нижних уровнях, 
 и связывать их с хранилищем данных. В качестве хранилища данных будут 
 использоваться файлы.
     */

namespace OrderManager.Infrastructure.Data
{
    public abstract class TData<T> : Data<T>, IData<T>
    {
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

        public static void SaveDialogue(T data, String filter, String defaultExt)
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

        public static void LoadDialogue(ref T data, String filter)
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

        public static void LoadFromFile(String path, ref T data)
        {
            if (!File.Exists(path))
                return;

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                data = (T)formatter.Deserialize(stream);
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

    [Serializable]
    public class CustomerData : TData<Customer>
    {

    }

    [Serializable]
    public class AssortmentData : TData<Item>
    {

    }
}
