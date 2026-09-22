using System.Collections.Generic;
using UnityEngine;
using UnityEngine.tvOS;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            LinkedListNode<int> first = list.First;
            LinkedListNode<int> currentNode = list.First.Next;

            while (currentNode != null)
            {
                if (currentNode.Value < first.Value)
                {
                    first.Value = currentNode.Value;
                    currentNode = currentNode.Next;
                }
                else
                {
                    currentNode = currentNode.Next;
                    currentNode.Value = first.Value;
                }
            }

            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    if (currentNode.Value < first.Value)
            //    {
            //        first = currentNode;
            //    }

            //    else
            //    {
            //        currentNode = currentNode.Next;
            //    }
            //}

            Debug.Log(list);
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            LinkedListNode<int> last = list.Last;
            LinkedListNode<int> currentNode = list.Last.Next;

            while (currentNode != null)
            {
                if (currentNode.Value > last.Value)
                {
                    last.Value = currentNode.Value;
                    currentNode = currentNode.Previous;
                }
                else
                {
                    currentNode = currentNode.Previous;
                }
            }

            return list;
        }
    }
}
