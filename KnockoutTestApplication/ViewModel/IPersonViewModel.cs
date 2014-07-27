using System;
namespace KnockoutTestApplication.ViewModel
{
    public interface IPersonViewModel
    {
        ICountry Country { get; set; }
        int CountryId { get; set; }
        DateTime DateOfBirth { get; }
        int Id { get; }
        string Name { get; }
    }
}
