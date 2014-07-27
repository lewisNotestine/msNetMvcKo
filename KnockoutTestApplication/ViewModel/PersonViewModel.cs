using System;

namespace KnockoutTestApplication.ViewModel {
    public class PersonViewModel : IPersonViewModel 
    {
        private PersonViewModel(int id, string name, DateTime dob)
        {
            _id = id;
            _name = name;
            _dob = dob;
        }

        public static IPersonViewModel Create(int id, string name, DateTime dob)
        {
            return new PersonViewModel(
                id: id,
                name: name,
                dob: dob);
        }

        private readonly int _id;
        public int Id { get { return _id; } }

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly DateTime _dob;
        public DateTime DateOfBirth { get { return _dob; } }

        public int CountryId { get; set; }
        public ICountry Country { get; set; }
    }

    public class Country : ICountry
    {
        private Country(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public static ICountry Create(int id, string name)
        {
            return new Country(
                id: id,
                name: name);
        }

        private const int ABBR_LEN = 3;

        private readonly int _id;
        public int Id { get { return _id; } }

        private readonly string _name;
        public string Name { get { return _name; } }

        public string Abbreviation { get { return Name.Substring(0, ABBR_LEN); } }
    }
}