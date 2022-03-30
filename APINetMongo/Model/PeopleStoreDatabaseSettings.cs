namespace APINetMongo.Models
{
    public class PeopleStoreDatabaseSettings : IPeopleStoreDatabaseSettings
    {
        public string LabNetCollection { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DataBaseName { get; set; } = String.Empty;
    }
}