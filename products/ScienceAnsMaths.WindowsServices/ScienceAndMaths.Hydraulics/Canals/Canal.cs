﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScienceAndMaths.Shared.Canals;

namespace ScienceAndMaths.Hydraulics.Canals
{
    /// <summary>
    /// Represents a canal configuration with a set of edges and stretches.
    /// </summary>
    public class Canal
    {
        public Canal()
        {
            CanelEdges = new List<CanalEdge>();
            CanalStretches = new List<CanalStretch>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for the canal.
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or sets the canal edges to define the boundary conditions.
        /// </summary>
        public List<CanalEdge> CanelEdges;

        /// <summary>
        /// Gets or sets the canal homogeneous sections.
        /// </summary>
        public List<CanalStretch> CanalStretches;

        /// <summary>
        /// Executes the canal simulation
        /// </summary>
        /// <returns></returns>
        public CanalSimulationResult ExecuteCanalSimulation()
        {
            return new CanalSimulationResult();
        }
    }
}
