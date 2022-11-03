// <copyright file="Character.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.ASSNeo
{
    public class Character
    {
        private List<PointF> points = new List<PointF>();
        private PointF origin = new PointF(0, 0);

        public Character()
        {
        }

        public void AddPointF(PointF p)
        {
            this.points.Add(p);
        }

        public void AddPointF(float x, float y)
        {
            this.AddPointF(new PointF(x, y));
        }

        public PointF GetPointF(int index)
        {
            return this.points[index];
        }
    }
}
