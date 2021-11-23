using FluentMigrator;

namespace OzonEdu.Merchandise.Migrator.Migrations
{   
    [Migration(5)]
    public class SkusTable: Migration {
        public override void Up()
        {
            Create
                .Table("skus")
                .WithColumn("id").AsInt64().Identity().PrimaryKey()
                .WithColumn("sku_id").AsInt64().NotNullable()
                .WithColumn("sky_set_id").AsInt64().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("skus");
        }
    }
}