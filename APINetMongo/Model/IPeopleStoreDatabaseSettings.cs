namespace APINetMongo.Models
{
    public interface IPeopleStoreDatabaseSettings
    {
        string LabNetCollection { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }

    }
}