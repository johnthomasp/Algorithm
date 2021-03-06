﻿using System;

namespace ToeplitzMatrix
{
    /* 
    A matrix is Toeplitz if every diagonal from top-left to bottom-right has the same element.
    Now given an M x N matrix, return True if and only if the matrix is Toeplitz. 
     https://leetcode.com/problems/toeplitz-matrix/description/
    */
    class Program
    {

        public static bool isToeplitzMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[,] matrix = 
          //{
          // {1, 2, 3, 4},
          // {5, 1, 2, 3},
          // {9, 5, 1, 2}
          //};
            {
             { 1, 2, 3, 4},
             { 5, 1, 2, 3},
             { 9, 5, 3, 2}
            };
            bool result = isToeplitzMatrix(matrix);
            Console.WriteLine(result == true ? "The Matrix is a ToeplitzMatrix" : "The Matrix is not ToeplitzMatrix");
            Console.ReadLine();
        }
    }
}