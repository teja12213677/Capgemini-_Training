using System;
namespace STUDENTMGMTSYSTEMAPP
{
    public class Student
    {
        int rollNo;
        int _phy;
        int _chem;
        int _math;
        int total;
        float perc;

        public int RollNo
        {
            set { rollNo = value; }
            get { return rollNo; }
        }
        public string Name { set; get; }
        public string Address { set; get; }
        public int phy
        {
            get { return _phy; }
            set
            {
                if (value >= 0 && value <= 100)
                    _phy = value;
                else
                    throw new InvalidMarksException("Invalid marks");
            }
        }
        public int chem
        {
            get { return _chem; }
            set
            {
                if (value >= 0 && value <= 100)
                    _chem = value;
                else
                    throw new InvalidMarksException("Invalid marks");
            }
        }
        public int math
        {
            get { return _math; }
            set
            {
                if (value >= 0 && value <= 100)
                    _math = value;
                else
                    throw new InvalidMarksException("Invalid marks");
            }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        public float Perc
        {
            get { return perc; }
            set { perc = value; }
        }
    }
}
