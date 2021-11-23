using FluentMigrator;

namespace OzonEdu.Merchandise.Migrator.Migrations
{
    [Migration(6)]
    public class SkuSetsTable : Migration{
        public override void Up()
        {
            Create
                .Table("sku_sets")
                .WithColumn("id").AsInt64().Identity().PrimaryKey()
                .WithColumn("set_id").AsInt64().NotNullable()
                .WithColumn("set_type_id").AsInt32().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("sku_sets");
        }
    }
}