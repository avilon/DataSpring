using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Domain
{
    public class EntityList<T> where T : Entity, new()
    {
        public EntityList()
        {
            entities = new List<T>();
        }

        public int Count {get {return entities.Count;}}

        public void Load(string file)
        {
            try
            {
                logger.Info("Start read file: " + file);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(file))
                {
                    string line;
                    entities.Clear();
                    while ((line = reader.ReadLine()) != null)
                    {
                        T entity = new T();
                        entity.Read(line);
                        entities.Add(entity);

                    }
                    reader.Close();
                }
                logger.Info("End read file: " + file);
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
        }

        private List<T> entities;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
    }
}
