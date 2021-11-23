using FluentMigrator;
using FluentMigrator.Infrastructure;

namespace OzonEdu.Merchandise.Migrator.Migrations
{
    [Migration(1)]
    public class SetTypeTable : Migration {
        public override void Up()
        {
            Create
                .Table("set_types")
                .WithColumn("id").AsInt32().PrimaryKey()
                .WithColumn("name").AsString().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("set_types");
        }
    }
}