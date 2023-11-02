using System;
using System.Collections;
using System.Collections.Generic;
namespace program
{
    class School //Create School class
    {
        //Declaring variables
        private string SchoolName;
        private string Location;
        private string District;
        private string Province;
        private bool PrivateInstitution;
        private int Rank;
        //Constructor to initialize the variables
        public School(string SchoolName, string Location, string District,
        string Province, bool PrivateInstitution, int Rank)
        {
            this.SchoolName = SchoolName;
            this.Location = Location;
            this.District = District;
            this.Province = Province;
            this.PrivateInstitution = PrivateInstitution;
            this.Rank = Rank;
        }
        //Getter and Setter methods for the variables
        public string schoolname
        {
            get { return SchoolName; }
            set { SchoolName = value; }
        }
        public string location
        {
            get { return Location; }
            set { Location = value; }
        }
        public string district
        {
            get { return District; }
            set { District = value; }
        }
        public string province
        {
            get { return Province; }
            set { District = value; }
        }
        public bool privateinstitution
        {
            get { return PrivateInstitution; }
            set { PrivateInstitution = value; }
        }
        public int rank
        {
            get { return Rank; }
            set { Rank = value; }
        }
        //Method that sets the rank of the school
        public void setRank(int Rank)
        {
            this.Rank = rank;
        }
        //Method to print the school object 
        public void print()
        {
            Console.WriteLine("School Name: " + schoolname);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("District: " + district);
            Console.WriteLine("Province: " + province);
            Console.WriteLine("Private Institute: " + privateinstitution);
            Console.WriteLine("Rank: " + rank);
        }
    }
    class College : School // Class called College that inherits from the School class:
    {
        private string type; //Add a variable called type
        public College(string SchoolName, string Location, string District, //Constructor that calls the Super Constructor
        string Province, bool PrivateInstitution, int Rank,
        string type) : base(SchoolName, Location, District, Province, //Constructor that calls the Super Constructor
        PrivateInstitution, Rank)
        {
            this.type = type;
        }
        public string Type //Getter and Setter for the variable
        {
            get { return type; }
            set { type = value; }
        }
        public new void print() //Override the method to print object
        {
            Console.WriteLine("College Name: " + schoolname);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("District: " + district);
            Console.WriteLine("Province: " + province);
            Console.WriteLine("Private Institute: " + privateinstitution);
            Console.WriteLine("Rank: " + rank);
            Console.WriteLine("Type: " + type);
        }
    }
    class University : School // Class called University: 

    {
        private int rating; // Variable called rating
        public University(string SchoolName, string Location, string District,
        string Province, bool PrivateInstitution, int Rank,
        int Rating) : base(SchoolName, Location, District, Province, PrivateInstitution,
            Rank)
        {
            this.rating = Rating;
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public new void print() //Override the method to print object 
        {
            Console.WriteLine("University Name: " + schoolname);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("District: " + district);
            Console.WriteLine("Province: " + province);
            Console.WriteLine("Private Institute: " + privateinstitution);
            Console.WriteLine("Rank: " + rank);
            Console.WriteLine("Rating: " + Rating);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Objects of type school, college and university.
            School school = new School("New West Secondary", "Durban", "District 7",
            "KwaZulu Natal", true, 1);
            College college = new College("Richfield Graduate Institute Of Technology",
            "Durban", "District 2",
             "KwaZulu Natal", false, 2, "Type 1");
            University university = new University("UKZN University", "Durban",
            "District 3", "KwaZulu Natal", true, 3, 5);

            //ArrayList and add the objects to the ArrayList.
            ArrayList list = new ArrayList();
            list.Add(school);
            list.Add(college);
            list.Add(university);
            foreach (School s in list)
            {
                s.print();
                Console.WriteLine();
            }
        }
    }
}

