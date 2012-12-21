using System.Collections.Generic;
using System.Linq;

namespace thn.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public static IQueryable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country {
                    Code = "AF",
                    Name = "Afghanistan"
                },
                new Country {
                    Code = "AL",
                    Name = "Albania"
                },
                new Country {
                    Code = "DZ",
                    Name = "Algeria"
                },
                new Country {
                    Code = "AS",
                    Name = "American Samoa"
                },
                new Country {
                    Code = "AD",
                    Name = "Admorra"
                },
                new Country {
                    Code = "AO",
                    Name = "Angola"
                },
                new Country {
                    Code = "AI",
                    Name = "Anguilla"
                },
                new Country {
                    Code = "AQ",
                    Name = "Antarctica"
                },
                new Country {
                    Code = "AG",
                    Name = "Antigua and Barbuda"
                },
                new Country {
                    Code = "AR",
                    Name = "Argentina"
                },
                new Country {
                    Code = "AM",
                    Name = "Armenia"
                },
                new Country {
                    Code = "AW",
                    Name = "Aruba"
                },
                new Country {
                    Code = "AU",
                    Name = "Australia"
                },
                new Country {
                    Code = "AT",
                    Name = "Austria"
                },
                new Country {
                    Code = "AZ",
                    Name = "Azerbaijan"
                },
                new Country {
                    Code = "BS",
                    Name = "Bahamas"
                },
                new Country {
                    Code = "BH",
                    Name = "Bahrain"
                },
                new Country {
                    Code = "BD",
                    Name = "Bangladesh"
                },
                new Country {
                    Code = "BB",
                    Name = "Barbados"
                },
                new Country {
                    Code = "BY",
                    Name = "Belarus"
                },
                new Country {
                    Code = "BE",
                    Name = "Belgium"
                },
                new Country {
                    Code = "BZ",
                    Name = "Belize"
                },
                new Country {
                    Code = "BJ",
                    Name = "Benin"
                },
                new Country {
                    Code = "BM",
                    Name = "Bermuda"
                },
                new Country {
                    Code = "BT",
                    Name = "Bhutan"
                },
                new Country {
                    Code = "BO",
                    Name = "Bolivia"
                },
                new Country {
                    Code = "BQ",
                    Name = "Bonaire"
                },
                new Country {
                    Code = "BA",
                    Name = "Bosnia"
                },
                new Country {
                    Code = "BW",
                    Name = "Botswana"
                },
                new Country {
                    Code = "BV",
                    Name = "Bouvet Island"
                },
                new Country {
                    Code = "BR",
                    Name = "Brazil"
                },
                new Country {
                    Code = "BN",
                    Name = "Brunei"
                },
                new Country {
                    Code = "BG",
                    Name = "Bulgaria"
                },
                new Country {
                    Code = "BF",
                    Name = "Burkina Faso"
                },
                new Country {
                    Code = "BI",
                    Name = "Burundi"
                },
                new Country {
                    Code = "KH",
                    Name = "Cambodia"
                },
                new Country {
                    Code = "CM",
                    Name = "Cameroon"
                },
                new Country {
                    Code = "CA",
                    Name = "Canada"
                },
                new Country {
                    Code = "CV",
                    Name = "Cape Verde"
                },
                new Country {
                    Code = "KY",
                    Name = "Cayman Islands"
                },
                new Country {
                    Code = "TD",
                    Name = "Chad"
                },
                new Country {
                    Code = "CL",
                    Name = "Chile"
                },
                new Country {
                    Code = "CN",
                    Name = "China"
                },
                new Country {
                    Code = "CX",
                    Name = "Christmas Island"
                },new Country {
                    Code = "CC",
                    Name = "Cocos Island"
                },
                new Country {
                    Code = "CO",
                    Name = "Colombia"
                },
                new Country {
                    Code = "KM",
                    Name = "Comoros"
                },
                new Country {
                    Code = "CG",
                    Name = "Congo"
                },
                new Country {
                    Code = "CD",
                    Name = "Congo, Democratic Republic of"
                },
                new Country {
                    Code = "CK",
                    Name = "Cook Islands"
                },
                new Country {
                    Code = "CR",
                    Name = "Costa Rica"
                },
                new Country {
                    Code = "CI",
                    Name = "Cote D'Ivoire"
                },
                new Country {
                    Code = "HR",
                    Name = "Croatia"
                },
                new Country {
                    Code = "CU",
                    Name = "Cuba"
                },
                new Country {
                    Code = "CW",
                    Name = "Curacao"
                },
                new Country {
                    Code = "CY",
                    Name = "Cyprus"
                },
                new Country {
                    Code = "CZ",
                    Name = "Czech Republic"
                },
                new Country {
                    Code = "DK",
                    Name = "Denmark"
                },
                new Country {
                    Code = "DJ",
                    Name = "Djibouti"
                },
                new Country {
                    Code = "DM",
                    Name = "Dominica"
                },
                new Country {
                    Code = "DO",
                    Name = "Dominican Republic"
                },
                new Country {
                    Code = "EC",
                    Name = "Ecuador"
                },
                new Country {
                    Code = "EG",
                    Name = "Egypt"
                },
                new Country {
                    Code = "SV",
                    Name = "El Salvador"
                },
                new Country {
                    Code = "GQ",
                    Name = "Equatorial Guinea"
                },
                new Country {
                    Code = "ER",
                    Name = "Eritrea"
                },
                new Country {
                    Code = "EE",
                    Name = "Estonia"
                },
                new Country {
                    Code = "ET",
                    Name = "Ethiopia"
                },
                new Country {
                    Code = "FK",
                    Name = "Falkland Islands"
                },
                new Country {
                    Code = "FO",
                    Name = "Faroe Islands"
                },

                
            }.AsQueryable();
        }
    }
}