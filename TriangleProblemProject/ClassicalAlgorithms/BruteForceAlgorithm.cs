﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.TriangleProblemProject.ClassicalAlgorithms {
    /// <summary>
    /// Go through every group of 3 nodes and see if they're connected.
    /// </summary>
    public class BruteForceAlgorithm : IAlgorithm {
        public string Name => "Brute Force";

        public (int,int,int) getTriangle(int[,] mat) {
            int nodes = mat.GetLength(0);
            for (int i = 0; i < nodes; i++) {
                for (int j = i+1; j < nodes; j++) {
                    // Check that the first 2 nodes are connected, before finding 3rd.
                    if (mat[i,j] == 1) {
                        for (int k = j+1; k < nodes; k++) {
                            if (mat[i,k] == 1 && mat[j,k] == 1) {
                                return (i,j,k);
                            }
                        }
                    }
                }
            }

            return (-1,-1,-1);
        }
        public bool Run(int[,] mat)
        {
            var retVals = getTriangle(mat);
            var (valOne, valTwo, valThree) = retVals;
            return (valOne != -1);
        }
    }
}
