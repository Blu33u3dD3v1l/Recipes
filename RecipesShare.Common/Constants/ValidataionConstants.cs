namespace RecipesShare.Common.Constants
{
    public class ValidataionConstants
    {
        public static class ClasicTrainerValidations
        {
            public const int NameMinValidation = 10;
            public const int NameMaxValidation = 50;

            public const int PractisMinValidation = 5;
            public const int PractisMaxValidation = 50;

            public const int InfoMinValidation = 10;
            public const int InfoMaxValidation = 5000;

            public const int MotoMinValidation = 10;
            public const int MotoMaxValidation = 5000;

            public const string PriceMinValidation = "1";
            public const string PriceMaxValidation = "200";

        }
        public static class BoxingTrainerValidations
        {
            public const int NameMinValidation = 10;
            public const int NameMaxValidation = 50;

            public const int PractisMinValidation = 5;
            public const int PractisMaxValidation = 50;

            public const int InfoMinValidation = 10;
            public const int InfoMaxValidation = 5000;

            public const int MotoMinValidation = 10;
            public const int MotoMaxValidation = 5000;
        }
        public static class ProductValidations
        {
            public const int NameMinValidation = 10;
            public const int NameMaxValidation = 500;

            public const int MarkMinValidation = 2;
            public const int MarkMaxValidation = 500;

            public const int DescriptionMinValidation = 10;
            public const int DescriptionMaxValidation = 5000;

        }
        public static class GroupEventsValidations
        {
            public const int NameMinValidation = 5;
            public const int NameMaxValidation = 20;

            public const int TimeMinValidation = 5;
            public const int TimeMaxValidation = 50;

            public const int DescriptionMinValidation = 10;
            public const int DescriptionMaxValidation = 5000;


        }
        public static class TypeNameValidations
        {

            public const int NameMinValidation = 3;
            public const int NameMaxValidation = 100;

        }
        public static class GroupTrainerNamesValidation
        {

            public const int NameMinValidation = 3;
            public const int NameMaxValidation = 50;

        }

        public static class GymValidations
        {
            public const int NameMinValidation = 10;
            public const int NameMaxValidation = 50;

            public const int TypeMinValidation = 5;
            public const int TypeMaxValidation = 50;

            public const int DesriptionMinValidation = 10;
            public const int DesriptionMaxValidation = 5000;

        }
        public static class AppointmentValidation
        {
            public const int ClientNameMinValidation = 5;
            public const int ClientNameMaxValidation = 50;

            public const int TrainerNameMinValidation = 5;
            public const int TrainerNameMaxValidation = 50;
        }
        public static class AppUserValidations
        {
           
            public const int UserFirstNameMaxValidation = 13;
            public const int UserLastNameMaxValidation = 20;

            
        }
    }
}
