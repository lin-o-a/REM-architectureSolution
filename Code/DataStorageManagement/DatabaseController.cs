using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models;

public class DatabaseController : DataConnection {
        
    #region private properties
    private static MappingSchema mappingSchema;
    #endregion

    #region public properties
    public ITable<Issue> Issues => this.GetTable<Issue>();
    public ITable<Task> Tasks => this.GetTable<Task>();
    #endregion

    #region constructor
    public DatabaseController() : base(ProviderName.SqlServer2017, "connection string")
    {
        if (mappingSchema == null)
            mappingSchema = InitContextMappings(this.MappingSchema);
    }
    #endregion

    private static MappingSchema InitContextMappings(MappingSchema dbSchemaMapping)
    {
        dbSchemaMapping.GetFluentMappingBuilder()
            .Entity<Issue>()
            .HasTableName("Issue")
            .HasPrimaryKey(i => i.Id).HasIdentity(i => i.Id)
            .Property(i => i.Id).HasColumnName("Name")
        
            .Association(t => t.Tasks, t => t.Id, i => i.IssueId);

        dbSchemaMapping.GetFluentMappingBuilder()
            .Entity<Task>()
            .HasTableName("Task")
            .HasPrimaryKey(t => t.Id).HasIdentity(t => t.Id)

            .Association(t => t.Issue, t => t.IssueId, i => i.Tasks);

        return dbSchemaMapping;
    }
}