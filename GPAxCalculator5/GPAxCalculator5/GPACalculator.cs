﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAxCalculator5
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private string name = "";//string.Empty
        private string alldata = "";
        private double min = 0;
        private string maxname = "";
        private string minname = "";

        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + "" + gpa;

            if (this.max < gpa)
            {
                this.max = gpa;
                this.min = gpa;
            }
        }
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return maxname;
        }
        public string getAllData()
        {
            return alldata;
        }
        public double getMin()
        {
            return this.min;
        }
        public string getMinName()
        {
            return minname;
        }
    }
}    
