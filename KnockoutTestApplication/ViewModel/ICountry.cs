using System;
namespace KnockoutTestApplication.ViewModel
{
    public interface ICountry
    {
        string Abbreviation { get; }
        int Id { get; }
        string Name { get; }
    }
}
