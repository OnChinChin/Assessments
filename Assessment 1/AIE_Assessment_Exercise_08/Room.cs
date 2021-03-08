using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Room
    {
        protected GameObject[] objects = new GameObject[3]; // assigning array to objs . name of array

        public void AddGameObject(GameObject go)
        {
            for (int i=0; i < objects.Length; i++)
            {
                if(objects[i] == null)
                {
                    objects[i] = go;
                    break;
                }
             }
        }

        public void RemoveGameObject(GameObject go)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == go)
                {
                    objects[i] = null;

                    objects.OrderByDescending(obj => (obj == null ? 0 : 1)).ToArray();

                    break;
                }
             }
        }

        public void Draw()
        {
            if (objects[0] == null)
            {
                Console.Write("_");
            }
            else
            {
                objects[0].Draw();
            }
        }
    }
}
