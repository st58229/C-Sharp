using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace fei
{
    class Student : IEquatable<Student>, IComparable<Student>
    {
        public enum Fac { FES, FF, FEI, FCHT, NoN };

        public string Name { get; set; }
        public int Id { get; set; }
        public Fac Faculty { get; set; }

        public static Fac FacultyFromString(string input)
        {
            switch (input)
            {
                case "FES":
                    return Fac.FES;
                case "FF":
                    return Fac.FF;
                case "FEI":
                    return Fac.FEI;
                case "FCHT":
                    return Fac.FCHT;
                default:
                    return Fac.NoN;
            }
        }

        public Student(string name, int id, Fac faculty)
        {
            Name = name;
            Id = id;
            Faculty = faculty;            
        }

        public override string ToString()
        {
            return $"Student named: {Name} with ID of {Id} study on faculty {Faculty}.";
        }

        public override bool Equals([AllowNull] object obj)
        {
            if (obj == null) return false;
            Student oStud = obj as Student;
            if (oStud == null) return false;
            else return Equals(oStud);
        }

        public int SortByName(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }

        public int CompareTo([AllowNull] Student comp)
        {
            if (comp == null) return 1;
            else return this.Id.CompareTo(comp.Id);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public bool Equals(Student other)
        {
            if (other == null) return false;
            else return (this.Id.Equals(other.Id));
        }
    }
}
