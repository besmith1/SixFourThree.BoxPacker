﻿using System.Collections;
using System.Linq;

namespace SixFourThree.BoxPacker.Model
{
    public class BoxList : MinHeap<Box>
    {
        public BoxList ShallowCopy()
        {
            BoxList othercopy = (BoxList)MemberwiseClone();

            othercopy.Content = new ArrayList();

            var items = Content.Cast<Box>();
            othercopy.Content.AddRange(items.ToArray());

            return othercopy;
        }
        public int ReverseCompareTo(Box boxA, Box boxB)
        {
            if (boxB.InnerVolume > boxA.InnerVolume)
                return 1;
            
            if (boxB.InnerVolume < boxA.InnerVolume) 
                return -1;
            
            return 0;
        }
    }
}
