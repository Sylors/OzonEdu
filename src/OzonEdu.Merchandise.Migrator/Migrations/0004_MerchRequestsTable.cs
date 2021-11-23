using FluentMigrator;

namespace OzonEdu.Merchandise.Migrator.Migrations
{
    [Migration(4)]
    public class MerchRequestsTable: Migration {
        public override void Up()
        {
            Create
                .Table("merch_requests")
                .WithColumn("id").AsInt64().Identity().PrimaryKey()
                .WithColumn("request_id").AsInt64().NotNullable()
                .WithColumn("request_status").AsInt32().NotNullable()
                .WithColumn("employee_id").AsInt64().NotNullable()
                .WithColumn("employee_email").AsString().NotNullable()
                .WithColumn("clothing_size").AsInt32().NotNullable()
                .WithColumn("creation_date").AsDateTimeOffset().NotNullable()
                .WithColumn("give_out_Date").AsDateTimeOffset().Nullable()
                .WithColumn("sky_set_id").AsInt64().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("merch_requests");
        }
    }
}