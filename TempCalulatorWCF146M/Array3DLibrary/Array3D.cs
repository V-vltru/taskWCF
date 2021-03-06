﻿namespace Array3DLibrary
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class Array3D<T>
    {
        private T[] Items;
        private int xLength;
        private int yLength;
        private int zLength;

        private int MaxItemNumber;

        private bool CheckParameters(int x, int y, int z, out string errorMessage)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                errorMessage = "All indexes must be not negative!";
                return false;
            }
            else if (z * xLength * yLength + y * XLength + x > MaxItemNumber)
            {
                errorMessage = "Index " + (z * xLength * yLength + y * XLength + x).ToString() + "is out of range";
                return false;
            }
            else
            {
                errorMessage = null;
                return true;
            }
        }

        #region Constructors
        public Array3D(int xSize, int ySize, int zSize)
        {
            Items = new T[xSize*ySize*zSize];

            XLength = xSize;
            YLength = ySize;
            ZLength = zSize;

            MaxItemNumber = xLength * YLength * ZLength - 1;
        }

        public Array3D(int xSize, int ySize, int zSize, List<T> listItems) : this(xSize, ySize, zSize)
        {
            Items = listItems.ToArray();
        }
        #endregion

        #region Indexer and Properties
        public T this[int x, int y, int z]
        {
            get
            {
                string errorMessage;
                if (CheckParameters(x, y, z, out errorMessage))
                {
                    return Items[z * xLength * yLength + y * XLength + x];
                }
                else
                    throw new Exception(errorMessage);
            }
            set
            {
                string errorMessage;
                if (CheckParameters(x, y, z, out errorMessage))
                {
                    Items[z * xLength * yLength + y * XLength + x] = value;
                }
                else
                    throw new Exception(errorMessage);
            }
        }

        public int XLength
        {
            get
            {
                return xLength;
            }

            set
            {
                if (value < 0)
                    throw new Exception("X size couldn't be less then zero");
                else
                    xLength = value;
            }
        }

        public int YLength
        {
            get
            {
                return yLength;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Y size couldn't be less then zero");
                else
                    yLength = value;
            }
        }

        public int ZLength
        {
            get
            {
                return zLength;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Y size couldn't be less then zero");
                else
                    zLength = value;
            }
        }
        #endregion
    }
}
